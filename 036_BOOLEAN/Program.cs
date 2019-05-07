using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_BOOLEAN
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

            bool compareX1X2 = point_x1 == point_x2;
            bool compareY1Y2 = point_y1 == point_y2;

            bool res = compareX1X2 || compareY1Y2;

            Console.WriteLine("Результат = {0}", res);
        }

    }
}
