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
            int countDigit = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write($"Введите {i + 1} число массива: ");
                input = Console.ReadLine();
                numbersArray[i] = int.Parse(input);
            }

            int tmp;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                tmp = numbersArray[i];
                while(tmp >= 1)
                {
                    tmp /= 10;
                    countDigit++;
                }
                
                switch(countDigit)
                {
                    case 1:
                    {
                        countSingleDigit++;
                        break;
                    }
                    case 2:
                    {
                        countTwoDigit++;
                        break;
                    }
                    case 3:
                    {
                        countThreeDigit++;
                        break;
                    }
                }
                countDigit = 0;
            }

        }
    }
}
