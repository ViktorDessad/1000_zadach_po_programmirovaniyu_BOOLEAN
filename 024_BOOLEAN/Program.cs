using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения переменных А,В,С");
            int number_A = Convert.ToInt32(Console.ReadLine());
            int number_B = Convert.ToInt32(Console.ReadLine());
            int number_C = Convert.ToInt32(Console.ReadLine());

            // Уравнение
            double discriminant = Math.Abs(Math.Pow(number_B, 2) - 4 * number_A * number_C);

            double res_x1 = (-number_B - Math.Sqrt(discriminant)) / 2 * number_A;
            double res_x2 = (-number_B + Math.Sqrt(discriminant)) / 2 * number_A;
            //Решение
            bool resCompare = res_x1 % 1 != 0 && res_x2 % 1 != 0;

            Console.WriteLine("Корни уравнения имеют вещественные числа {0}, корни {1} и {2}",
                resCompare, res_x1, res_x2);

            

        }
    }
}
