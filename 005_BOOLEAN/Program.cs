using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А и В");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());

            bool A = number_A > 0;
            bool B = number_B <= -2;

            bool trueOrFalse = A && B;

            Console.WriteLine("Результат A > 0 - {0}, B <= -2 - {1}, A > 0 и B <= -2 - {2}", A, B, trueOrFalse);
        }
    }
}
