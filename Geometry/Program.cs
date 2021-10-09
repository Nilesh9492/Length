using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter coordinates x and y respctively of point A:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates x and y respctively of point A:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = x2 - x1;
            double y = y2 - y1;
            double pow_x = Math.Pow(x,2);
            double pow_y = Math.Pow(y, 2);
            double z = pow_x + pow_y;
            Console.WriteLine("Length of Line is:" + Math.Sqrt(z));



        }
    }
}
