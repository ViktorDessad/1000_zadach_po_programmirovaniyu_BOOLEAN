using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_BOOLEAN
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

            bool horse = ((Math.Abs(point_x1 - point_x2) == 1) && (Math.Abs(point_y1 - point_y2) == 2));
            bool horse1 = ((Math.Abs(point_x1 - point_x2) == 2) && (Math.Abs(point_y1 - point_y2) == 1));

            bool res = horse || horse1;

            Console.WriteLine("Результат = {0}", res);
        }
    }
}
