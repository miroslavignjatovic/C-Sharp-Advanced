using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv4Homework
{
    public class GenericDb<T> where T : Shape
    {
        private List<T> shapes;

        public GenericDb()
        {
            shapes = new List<T>();
        }

        public void AddShape(T shape)
        {
            shapes.Add(shape);
        }

        public void PrintAreas()
        {
            foreach (T shape in shapes)
            {
                double area = shape.GetArea();
                Console.WriteLine($"Shape ID: {shape.Id}, Area: {area}");
            }
        }
        public void PrintPerimeters()
        {
            foreach (T shape in shapes)
            {
                double perimeter = shape.GetPerimeter();
                Console.WriteLine($"Shape ID: {shape.Id}, Perimeter: {perimeter}");
            }
        }
    }
   
}
