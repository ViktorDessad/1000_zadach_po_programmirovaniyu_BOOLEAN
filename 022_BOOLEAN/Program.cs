using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_BOOLEAN
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

            bool numberCompareUp = thirdNumber > secondNumber && secondNumber > firstNumber && thirdNumber > firstNumber;
            bool numberCompareDown = thirdNumber < secondNumber && secondNumber < firstNumber && thirdNumber < firstNumber;

            bool finalCompare = numberCompareUp || numberCompareDown;

            Console.WriteLine("Цифры {0}, {1}, {2} числа {3} образуют возрастающую или убывающую последовательность - {4}",
                firstNumber, secondNumber, thirdNumber, number, finalCompare);
        }
    }
}
