using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace CasAdv11Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Pera",
                Surname = "peric",
                Age = 25,
                Course = new List<Course>
                 {
                    new Course { Name = "csarp", Grade = 9 },
                    new Course { Name = "javascript", Grade = 10 },
                    new Course { Name = "sql", Grade = 8 }
                 }
            };
            string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            File.WriteAllText("OnePerson.json", json);

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            
           
            string jsonData = File.ReadAllText("OnePerson.json");
            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonData);

            Console.WriteLine("Deserialized Person:");
            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Surname: {deserializedPerson.Surname}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine("Courses:");
            foreach (var course in deserializedPerson.Course)
            {
                Console.WriteLine($"  Course: {course.Name}, Grade: {course.Grade}");
            }

        }
    }
}
   