using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа А, В, С");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());
            int number_С = Convert.ToInt32(Console.ReadLine());

            bool A = number_A > 0 && number_B > 0 && number_С <= 0;
            bool B = number_B > 0 && number_С > 0 && number_A <= 0;
            bool C = number_С > 0 && number_A > 0 && number_B <= 0;

            bool trueOrFalse = A || B || C;
            Console.WriteLine("Число А={0} - {1}, число В={2} - {3}," +
                "число C={4} - {5}, общий результат - {6}",
                number_A, A, number_B, B, number_С, C, trueOrFalse);
        }
    }
}
