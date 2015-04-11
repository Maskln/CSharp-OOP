namespace Shapes
{
    using System;
    using System.Linq;

    class ShapesMain
    {
        static void Main()
        {
            //Test
            Console.WriteLine("Test mode");
            Console.WriteLine("---------");

            var trngl = new Triangle(5, 3.5);
            Console.WriteLine(trngl);
            


            var rect = new Rectangle(5, 3.5);
            Console.WriteLine(rect);

            var squr = new Square(3.21);
            Console.WriteLine(squr);

            Console.WriteLine();

            //Write a program that tests the behaviour of the CalculateSurface()
            //method for different shapes (Square, Rectangle, Triangle) stored in an array.
            Console.WriteLine("Array of Shapes");
            Console.WriteLine("---------------");

            Shape[] shapes = new Shape[] { new Triangle(2.36, 4.6), new Rectangle(5, 4), new Square(6.66) };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
