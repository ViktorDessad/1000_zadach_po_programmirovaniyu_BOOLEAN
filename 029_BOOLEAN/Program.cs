using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точек прямоугольника");
            Console.Write("x1 = ");
            int point_x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            int point_y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            int point_x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            int point_y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите координаты точек x и y");
            Console.Write("x = ");
            int point_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int point_y = Convert.ToInt32(Console.ReadLine());

            bool compareRectanglePoint = point_x2 > point_x1 && point_y1 > point_y2;
            bool compareXY = point_x > point_x1 && point_x < point_x2 && point_y > point_y2 && point_y < point_y1;

            Console.WriteLine($"Это прямоугольник? ответ - {compareRectanglePoint}, точки {point_x} и {point_y} находятся внутри прямоугольника?" +
                $" ответ - {compareXY}");

            


        }
    }
}
