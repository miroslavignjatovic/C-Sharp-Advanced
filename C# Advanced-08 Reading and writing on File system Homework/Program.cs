using System;
using System.IO;


namespace C__Advanced_08_Reading_and_writing_on_File_system_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"E:\Miroslav\Programiranje\C#\C# Advanced-08 Reading and writing on File system Homework";
            string filesPath = Path.Combine(appPath, "myFolder");
            string testTxtPath = Path.Combine(filesPath, "test.txt");

            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
            }

            if (!File.Exists(testTxtPath))
            {
                using (File.Create(testTxtPath)) { }
            }

           
            using (StreamWriter sw = new StreamWriter(testTxtPath))
            {
                sw.WriteLine("We are students in school");
                sw.WriteLine("We are writing text from StreamWriter!");
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine("We are writing text from StreamWriter!");

                Console.WriteLine("Writing is complete!");
            }

            List<string> lines = new List<string>();

           
           
                string filePath = @"E:\Miroslav\Programiranje\C#\C# Advanced-08 Reading and writing on File system Homework\myFolder\test.txt"; 
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            

            Console.WriteLine("Text file loaded. Enter text to search or press Enter to exit.");

            while (true)
            {
                Console.Write("Enter search text: ");
                string searchText = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    Console.WriteLine("Exiting application.");
                    break;
                }

                bool found = false;
                foreach (string line in lines)
                {
                    if (line.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(line);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No matching lines found.");
                }
            }
        }
    }
}