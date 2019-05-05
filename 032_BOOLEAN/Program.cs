using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника a, b, c");
            int side_a = Convert.ToInt32(Console.ReadLine());
            int side_b = Convert.ToInt32(Console.ReadLine());
            int side_c = Convert.ToInt32(Console.ReadLine());

            bool triangle = Math.Pow(side_c, 2) == Math.Pow(side_a, 2) + Math.Pow(side_b, 2);

            Console.WriteLine("Данный треугольник со сторонами a={0}, b={1}, c={2} прямоугольный - {3}",
                side_a, side_b, side_c, triangle);
        }
    }
}
