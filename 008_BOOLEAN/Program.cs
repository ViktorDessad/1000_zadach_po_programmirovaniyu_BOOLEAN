using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А и В");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());


            bool A = (number_A % 2) > 0;
            bool B = (number_B % 2) > 0;

            Console.WriteLine("Число A = {0} - нечетное - {2}, число В = {1} - нечетное - {3}", 
                number_A, number_B, A, B);
            

        }
    }
}
