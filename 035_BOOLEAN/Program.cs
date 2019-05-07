using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты шахматной доски x1,y1,x2,y2 от 1 до 8");

            int point_x1 = Convert.ToInt32(Console.ReadLine());
            int point_y1 = Convert.ToInt32(Console.ReadLine());
            int point_x2 = Convert.ToInt32(Console.ReadLine());
            int point_y2 = Convert.ToInt32(Console.ReadLine());

            //bool table = point_x >= 1 && point_x <= 8 && point_y >= 1 && point_y <= 8;
            bool squareColorWhite = (point_x1 + point_y1) % 2 > 0 && (point_x2 + point_y2) % 2 > 0;
            bool squareColorBlack = (point_x1 + point_y1) % 2 == 0 && (point_x2 + point_y2) % 2 == 0;
            

            bool colorsCompare = squareColorBlack || squareColorWhite;


            Console.WriteLine("Координаты квадрата доски x1={0} y2={1} и x2={2},y2={3}, и оба цвета одинаковые - {4}",
                point_x1, point_y1, point_x2,point_y2, colorsCompare);
        }
    }
}
