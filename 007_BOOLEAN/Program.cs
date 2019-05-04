using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_BOOLEAN
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

            Console.WriteLine("Результат - {0}, B находится между А и С", trueOrFalse);
        }
    }
}
