using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А и В");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());

            bool answer_AB = number_A % 2 == 1 && number_B % 2 == 0; 
            bool answer_BA = number_A % 2 == 0 && number_B % 2 == 1;
            bool trueOrFalse = answer_AB || answer_BA;

            Console.WriteLine("Результат - {0}", trueOrFalse);
            

            
            

        }
    }
}
