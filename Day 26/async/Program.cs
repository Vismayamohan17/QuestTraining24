using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace async
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the path of the text file you want to read:");
            string filePath = Console.ReadLine();

            await Task.Delay(1000);

            try
            {

                string content = await File.ReadAllTextAsync(filePath);
                Console.WriteLine("\nFile Contents:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
