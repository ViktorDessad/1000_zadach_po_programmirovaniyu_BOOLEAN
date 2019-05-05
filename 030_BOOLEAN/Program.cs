using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника a, b, c");
            int side_a = Convert.ToInt32(Console.ReadLine());
            int side_b = Convert.ToInt32(Console.ReadLine());
            int side_c = Convert.ToInt32(Console.ReadLine());

            bool triangle = side_a == side_b && side_a == side_c && side_b == side_c;

            Console.WriteLine("Данный треугольник со сторонами {0}, {1}, {2} равносторонний - {3}", 
                side_a, side_b, side_c, triangle);
        }
    }
}
