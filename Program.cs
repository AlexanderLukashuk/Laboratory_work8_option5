using System;

namespace Task8v5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Дано число n. Определить сколько среди них 
            //*однозначных, двухзначных, трехзначных.

            string input;
            int size;
            Console.Write("Введите размер массива: ");
            input = Console.ReadLine();
            size = int.Parse(input);
            int[] numbersArray = new int[size];
            int countSingleDigit = 0;
            int countTwoDigit = 0;
            int countThreeDigit = 0;

        }
    }
}
