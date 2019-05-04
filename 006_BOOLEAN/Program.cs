using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А, В и С");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());
            int number_С = Convert.ToInt32(Console.ReadLine());

            bool AB = number_A < number_B;
            bool BC = number_B < number_С;

            bool trueOrFalse = AB && BC;

            Console.WriteLine("Результат A < B - {0}, B < C - {1}, A < B и B < C - {2}", AB, BC, trueOrFalse);
        }
    }
}
