using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х и у");
            int value_x = Convert.ToInt32(Console.ReadLine());
            int value_y = Convert.ToInt32(Console.ReadLine());

            bool @bool = value_x > 0 && value_y < 0;
            Console.WriteLine("Значения {0} и {1} лежат во IV чверти - {2}", value_x, value_y, @bool);
        }
    }
}
