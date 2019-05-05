using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_BOOLEAN
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

            bool numberCompare = thirdNumber > secondNumber && secondNumber > firstNumber && thirdNumber > firstNumber;

            Console.WriteLine("Цифры {0}, {1}, {2} числа {3} образуют возрастающую последовательность - {4}",
                firstNumber, secondNumber, thirdNumber, number, numberCompare);
        }
    }
}
