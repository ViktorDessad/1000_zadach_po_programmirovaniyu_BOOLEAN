using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());

            //bool compare = number >= 100 && number <= 999;

            int thirdNumber = number % 10;
            int secondNumber = (number % 100 - thirdNumber) / 10;
            int firstNumber = number / 100;

            bool numberCompare = firstNumber != secondNumber && secondNumber != thirdNumber && thirdNumber != firstNumber;

            Console.WriteLine("Число {0}, цифры числа {1}, {2}, {3} и все они разные - {4}",
                number, firstNumber, secondNumber, thirdNumber, numberCompare);
        }
    }
}
