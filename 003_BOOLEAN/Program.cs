using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int number_A = Convert.ToInt32(Console.ReadLine());

            bool trueOrFalse = number_A % 2 == 0;

            Console.WriteLine("Число {0} является четным - {1}", number_A, trueOrFalse);
        }
    }
}
