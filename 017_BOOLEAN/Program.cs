using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цело положительное число");
            int number = Convert.ToInt32(Console.ReadLine());

            bool @bool = number >= 100 && number < 1000 && number % 2 > 0;

            Console.WriteLine("Данное число {0} - {1} является нечетным трехзначным положительным числом",
                number, @bool);
        }
    }
}
