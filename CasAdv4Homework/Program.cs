namespace CasAdv4Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Creating a GenericDb for circles
            GenericDb<Circle> circleDb = new GenericDb<Circle>();

            Circle circle1 = new Circle { Id = 1, Radius = 5 };
            Circle circle2 = new Circle { Id = 2, Radius = 3.5 };

            circleDb.AddShape(circle1);
            circleDb.AddShape(circle2);

            circleDb.PrintAreas();
            circleDb.PrintPerimeters();

            // Creating a GenericDb for rectangles
            GenericDb<Rectangle> rectangleDb = new GenericDb<Rectangle>();

            Rectangle rectangle1 = new Rectangle { Id = 3, SideA = 4, SideB = 6 };
            Rectangle rectangle2 = new Rectangle { Id = 4, SideA = 2.5, SideB = 3.5 };

            rectangleDb.AddShape(rectangle1);
            rectangleDb.AddShape(rectangle2);

            rectangleDb.PrintAreas();
            rectangleDb.PrintPerimeters();

            Console.ReadLine();
        }
    }
}