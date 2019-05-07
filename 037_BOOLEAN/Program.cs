using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_BOOLEAN
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

            bool king = Math.Abs(point_x1 - point_x2) <= 1 && Math.Abs(point_y1 - point_y2) <= 1;

            

            Console.WriteLine("Результат = {0}", king);
        }
    }
}
