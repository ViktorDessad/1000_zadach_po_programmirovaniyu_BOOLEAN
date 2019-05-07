using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты шахматной доски x и y от 1 до 8");

            int point_x = Convert.ToInt32(Console.ReadLine());
            int point_y = Convert.ToInt32(Console.ReadLine());

            bool table = point_x >= 1 && point_x <= 8 && point_y >= 1 && point_y <= 8;
            bool squareColor = (point_x + point_y) % 2 > 0;
            

            Console.WriteLine("Координаты квадрата доски x={0} y={1}, а цвет квадрата: белый - {2}", 
                point_x, point_y, squareColor);

        }
    }
}
