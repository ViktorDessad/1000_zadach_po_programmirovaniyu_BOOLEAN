using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int number_A = Convert.ToInt32(Console.ReadLine());
            bool value = number_A > 0;

            Console.WriteLine("Число {0} является положительным - {1}", 
                number_A, value);
            
        }
    }
}
