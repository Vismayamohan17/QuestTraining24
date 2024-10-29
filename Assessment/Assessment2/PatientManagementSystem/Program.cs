using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int PatientId { get; set; }
    }

    public class PatientRepository
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VISMAYA MOHAN\\source\\repos\\QuestTraining24\\Assessment\\Assessment2\\PatientDb.mdf\";Integrated Security=True;Connect Timeout=30";
        public PatientRepository()
        {
            CreatePatientsTable();
        }
        private void CreatePatientsTable()
        {
            string createPatientTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Patients' AND xtype='U')
            CREATE TABLE Patients (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name VARCHAR(100) NOT NULL,
                Age INT NOT NULL,
                Gender VARCHAR(10) NOT NULL,
                MedicalCondition VARCHAR(200) NOT NULL
            );";

            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createPatientTableQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patients (Name, Age, Gender , MedicalCondition) VALUES (@Name, @Age, @Gender , @MedicalCondition)";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public Patient DisplayDetails(string input)
        {
            string query = "SELECT * FROM Patients WHERE Name = @Input";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Patient
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            Gender = reader.GetString(3),
                            MedicalCondition = reader.GetString(4),
                        };
                    }
                }
            }
            return null;
        }
        public void UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patients SET Name = @Name, Age = @Age, Gender = @Gender , MedicalCondition = @MedicalCondition WHERE Id = @Id";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@Gender", patient.Gender);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                command.Parameters.AddWithValue("@Id", patient.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePatient(int Id)
        {
            string query = "DELETE FROM Patients WHERE Id = @Id";
            using (var connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    public class DoctorRepository
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\VISMAYA MOHAN\\source\\repos\\QuestTraining24\\Assessment\\Assessment2\\DoctorDb.mdf\";Integrated Security=True;Connect Timeout=30";
        public DoctorRepository()
        {
            createDoctorsTable();
        }

        private void createDoctorsTable()
        {
            string createDoctorTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Doctors' AND xtype='U')
                    CREATE TABLE Doctors (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        Name VARCHAR(100) NOT NULL,
                        Specialization VARCHAR(100) NOT NULL,
                        PatientId INT NULL,
                        FOREIGN KEY (PatientId) REFERENCES Patients(Id)
                    )";

            using (var connection1 = new SqlConnection(connStr))
            {
                SqlCommand command1 = new SqlCommand(createDoctorTableQuery, connection1);
                connection1.Open();
                command1.ExecuteNonQuery();
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            string query1 = "INSERT INTO Doctors (Name, Specialization, PatientId) VALUES (@Name, @Specialization, @PatientId)";
            using (var connection1 = new SqlConnection(connStr))
            {
                SqlCommand command1 = new SqlCommand(query1, connection1);
                command1.Parameters.AddWithValue("@Name", doctor.Name);
                command1.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command1.Parameters.AddWithValue("@PatientId", doctor.PatientId);

                connection1.Open();
                command1.ExecuteNonQuery();
            }
        }

        public Doctor DisplayDetails(string input)
        {
            string query = "SELECT * FROM Doctors WHERE Name = @Input";
            using (var connection1 = new SqlConnection(connStr))
            {
                SqlCommand command1 = new SqlCommand(query, connection1);
                command1.Parameters.AddWithValue("@Input", input);

                connection1.Open();

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Specialization = reader.GetString(2),
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            string query = "UPDATE Doctors SET Name = @Name, Specialization = @Specialization WHERE Id = @Id";
            using (var connection1 = new SqlConnection(connStr))
            {
                SqlCommand command1 = new SqlCommand(query, connection1);
                command1.Parameters.AddWithValue("@Name", doctor.Name);
                command1.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command1.Parameters.AddWithValue("@Id", doctor.Id);


                connection1.Open();
                command1.ExecuteNonQuery();
            }
        }


        public void DeleteDoctor(int Id)
        {
            string query = "DELETE FROM Doctors WHERE Id = @Id";
            using (var connection1 = new SqlConnection(connStr))
            {
                SqlCommand command1 = new SqlCommand(query, connection1);
                command1.Parameters.AddWithValue("@Id", Id);

                connection1.Open();
                command1.ExecuteNonQuery();
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PatientRepository patientRepository = new PatientRepository();
            DoctorRepository doctorRepository = new DoctorRepository();

            patientRepository.AddPatient(new Patient { Name = "John Doe", Age = 32, Gender = "Male", MedicalCondition = "Fever" });

            var patient = patientRepository.DisplayDetails("John Doe");
            if (patient != null)
            {
                Console.WriteLine($"Found Patient: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Medical Condition: {patient.MedicalCondition}");

                patient.Name = "John Smith";
                patientRepository.UpdatePatient(patient);
                Console.WriteLine("Patient details updated.");

                patientRepository.DeletePatient(patient.Id);
                Console.WriteLine("Patient deleted.");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }

            doctorRepository.AddDoctor(new Doctor { Name = "Anna", Specialization = "Emergency" });

            var doctor = doctorRepository.DisplayDetails("Anna");
            if (doctor != null)
            {
                Console.WriteLine($"Found Doctor: {doctor.Name}, Specialization: {doctor.Specialization}");

                doctor.Name = "Anna Samuel";
                doctorRepository.UpdateDoctor(doctor);
                Console.WriteLine("Doctor details updated.");

                doctorRepository.DeleteDoctor(doctor.Id);
                Console.WriteLine("Doctor deleted.");
            }
            else
            {
                Console.WriteLine("Doctor not found.");
            }

            Console.ReadLine();
        }
    }
}
