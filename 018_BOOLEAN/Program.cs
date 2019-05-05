using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа А, В, С");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());
            int number_C = Convert.ToInt32(Console.ReadLine());

            bool AB = number_A == number_B && number_B == number_A;
            bool BC = number_B == number_C && number_C == number_B;
            bool CA = number_C == number_A && number_A == number_C;

            bool trueOrFalse = AB || BC || CA;

            Console.WriteLine("Два числа из трех совпадают A={0} - B={1} - C={2} - {3}", 
                number_A, number_B, number_C, trueOrFalse);

        }
    }
}
