using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_BOOLEAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());

            //bool compare = number >= 1000 && number <= 9999;

            int fourthNumber = number % 10;                                             // 1234 = 4
            int thirdNumber = (number % 100 - fourthNumber) / 10;                       // 1234 = 3
            int secondNumber = (number % 1000 - thirdNumber * 10 - fourthNumber) / 100; // 1234 = 2
            int firstNumber = number / 1000;                                            // 1234 = 1

            // 1111 - true , 1221-true, 1001 - true, 0110 - true

            bool firstCompare = firstNumber == secondNumber && secondNumber == thirdNumber && thirdNumber == fourthNumber;
            bool secondCompare = firstNumber > secondNumber && secondNumber == thirdNumber && thirdNumber < fourthNumber;
            bool thirdCompare = firstNumber < secondNumber && secondNumber == thirdNumber && thirdNumber > fourthNumber;

            bool finalCompare = firstCompare || secondCompare || thirdCompare;

            Console.WriteLine($"Данное число {number} одинаково читается справа налево и слева направо {firstCompare}");

            

           
        }
    }
}
