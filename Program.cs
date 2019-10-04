using System;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangles:");
            Console.WriteLine("-----------");
            Console.WriteLine("Rectangle of width 34 & height 25 has an area of {0}", Rectangle.GetArea(34, 25));
            Console.WriteLine("Rectangle of width 10 & height 5 has an area of {0}", Rectangle.GetArea(10, 5));
            Console.WriteLine("Rectangle of width 15 & height 30 has an area of {0}", Rectangle.GetArea(15, 30));
            Console.ReadKey(true);
        }
    }

    class Rectangle
    {
        public static int GetArea(int height, int width)
        {
            return (height * width);
        }
    }
}
