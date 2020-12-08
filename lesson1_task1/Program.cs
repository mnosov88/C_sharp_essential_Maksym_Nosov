using System;

namespace lesson1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Circle circle = new Circle();
                Console.WriteLine("Hello! Please, enter value of radius");

                circle.Radius = Convert.ToDouble(Console.ReadLine());

                // calculate and show circle's area
                double circleArea = circle.GetArea();
                Console.WriteLine("Circle area is " + circleArea);

                // calculate and show circle's length
                double circleLength = circle.GetCircumference();
                Console.WriteLine("Circle length is " + circleLength);

                // delay
                Console.ReadKey();
            }
        }
    }
}
