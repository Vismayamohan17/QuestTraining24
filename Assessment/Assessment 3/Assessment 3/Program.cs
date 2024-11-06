using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assessment_3
{
    public interface INoteRepository
    {
        void AddNote(Notes note);
        List<Notes> ViewAllNotes();
        void UpdateNote(Notes note);
        void DeleteNote(int id);
    }
    public class SqlNoteRepository : INoteRepository
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VISMAYA MOHAN\\OneDrive\\Documents\\NoteTakingApp.mdf\";Integrated Security=True;Connect Timeout=30";

        public SqlNoteRepository()
        {
            CreateNotesTable();
        }

        private void CreateNotesTable()
        {
            string createNoteTableQuery = @"
        CREATE TABLE Notes (
            Id INT PRIMARY KEY IDENTITY,
            Title NVARCHAR(100) NOT NULL,
            Content NVARCHAR(MAX) NOT NULL,
            CreatedAt DATETIME DEFAULT GETDATE(),
            UpdatedAt DATETIME
        );";

            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createNoteTableQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddNote(Notes note)
        {
            string query = "INSERT INTO Notes (Title, Content, CreatedAt, UpdatedAt) VALUES (@Title, @Content, @CreatedAt, @UpdatedAt)";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Notes> ViewAllNotes()
        {
            List<Notes> notesList = new List<Notes>();
            string query = "SELECT * FROM Notes";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notesList.Add(new Notes
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Content = reader.GetString(2),
                            CreatedAt = reader.GetDateTime(3),
                            UpdatedAt = reader.GetDateTime(4),
                        });
                    }
                }
            }
            return notesList;
        }

        public void UpdateNote(Notes note)
        {
            string query = "UPDATE Notes SET Title = @Title, Content = @Content, CreatedAt = @CreatedAt, UpdatedAt = @UpdatedAt WHERE Id = @Id";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);
                command.Parameters.AddWithValue("@Id", note.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteNote(int id)
        {
            string query = "DELETE FROM Notes WHERE Id = @Id";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
    public class NoteManager
    {
        private readonly INoteRepository _noteRepository;

        public NoteManager(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void AddNote()
        {
            Console.Write("Enter the note title: ");
            string title = Console.ReadLine();
            Console.Write("Enter the note content: ");
            string content = Console.ReadLine();

            Notes newNote = new Notes
            {
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _noteRepository.AddNote(newNote);
            Console.WriteLine("Note added successfully!");
        }

        public void ViewAllNotes()
        {
            var notes = _noteRepository.ViewAllNotes();

            if (notes.Count > 0)
            {
                Console.WriteLine("\n--- All Notes ---");
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, Created At: {note.CreatedAt}");
                }
            }
            else
            {
                Console.WriteLine("No notes available.");
            }
        }

        public void UpdateNote()
        {
            Console.WriteLine("\nEnter the ID of the note you want to update:");
            int id = int.Parse(Console.ReadLine());

            var notes = _noteRepository.ViewAllNotes();
            var note = notes.Find(n => n.Id == id);

            if (note != null)
            {
                Console.WriteLine($"\nCurrent Title: {note.Title}\nCurrent Content: {note.Content}");
                Console.WriteLine("Enter new title (leave empty to keep current):");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(newTitle)) note.Title = newTitle;

                Console.WriteLine("Enter new content (leave empty to keep current):");
                string newContent = Console.ReadLine();
                if (!string.IsNullOrEmpty(newContent)) note.Content = newContent;

                note.UpdatedAt = DateTime.Now;
                _noteRepository.UpdateNote(note);
                Console.WriteLine("Note updated successfully!");
            }
            else
            {
                Console.WriteLine("Note not found.");
            }
        }

        public void DeleteNote()
        {
            Console.WriteLine("\nEnter the ID of the note you want to delete:");
            int id = int.Parse(Console.ReadLine());

            var notes = _noteRepository.ViewAllNotes();
            var note = notes.Find(n => n.Id == id);

            if (note != null)
            {
                Console.WriteLine($"Are you sure you want to delete the note '{note.Title}'? (Y/N)");
                string confirmation = Console.ReadLine();
                if (confirmation.ToUpper() == "Y")
                {
                    _noteRepository.DeleteNote(id);
                    Console.WriteLine("Note deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Deletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("Note not found.");
            }
        }
    }
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }

    internal class Program
    {
        static bool exit = false;

        static void Main(string[] args)
        {
            INoteRepository repository = new SqlNoteRepository();
            NoteManager noteManager = new NoteManager(repository);

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update an existing note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        noteManager.AddNote();
                        break;
                    case 2:
                        noteManager.ViewAllNotes();
                        break;
                    case 3:
                        noteManager.UpdateNote();
                        break;
                    case 4:
                        noteManager.DeleteNote();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select an option between 1 and 5.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
