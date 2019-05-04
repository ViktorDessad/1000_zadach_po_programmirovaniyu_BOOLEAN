using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А и В");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());

            bool A = number_A > 2;
            bool B = number_B <= 3;

            bool trueOrFalse = A && B;

            Console.WriteLine("Результат A > 2 - {0}, B <= 3 - {1}, A > 2 и B <= 3 - {2}", A, B, trueOrFalse);
        }
    }
}
