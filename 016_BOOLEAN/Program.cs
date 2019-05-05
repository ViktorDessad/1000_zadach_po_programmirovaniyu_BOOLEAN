using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цело положительное число");
            int number = Convert.ToInt32(Console.ReadLine());

            bool @bool = number >= 10 && number < 100 && number % 2 == 0;

            Console.WriteLine("Данное число {0} - {1} является целым положительным двузначным четным числом", 
                number, @bool);

        }
    }
}
