using System;

namespace Task8v5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1. Дано число n. Определить сколько среди них 
            //*однозначных, двухзначных, трехзначных.

            /*string input;
            int size;
            Console.Write("Введите размер массива: ");
            input = Console.ReadLine();
            size = int.Parse(input);
            int[] numbersArray = new int[size];
            int countSingleDigit = 0;
            int countTwoDigit = 0;
            int countThreeDigit = 0;
            int countDigit = 0;
            int tmpInput = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write($"Введите {i + 1} число массива(от 1 до 999): ");
                input = Console.ReadLine();
                tmpInput = int.Parse(input);

                if (tmpInput < 1 || tmpInput > 999)
                {
                    while (tmpInput < 1 || tmpInput > 999)
                    {
                        Console.WriteLine("Введено неправильное число");
                        Console.Write("Попробуйте ввести число еще раз(ОТ 1 ДО 100): ");
                        input = Console.ReadLine();
                        tmpInput = int.Parse(input);
                    }
                }

                numbersArray[i] = tmpInput;
            }

            int tmp;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                tmp = numbersArray[i];
                while (tmp >= 1)
                {
                    tmp /= 10;
                    countDigit++;
                }

                switch (countDigit)
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

            Console.WriteLine($"Однозначных чисел = {countSingleDigit}, двухзначных чисел = {countTwoDigit}, трехзначных чисел = {countThreeDigit}");*/


            //* 2. Решить уравнение x2-ln (1+x)-3=0, х=[2;3], с шагом 0,2

            double x = 2;
            double y;
            //Console.WriteLine($"{Math.Log(1 - 2)}");
            while (x <= 3)
            {
                //y = Math.Pow(x, 2) - Math.Log(1 - x) - 3;
                y = Math.Pow(x, 2) - Math.Log(1, Math.E) * Math.Log(x, Math.E) - 3;
                //Console.WriteLine($"y = {y}");

                if (y == 0)
                {
                    Console.WriteLine($"y({y}) равен 0");
                }
                else
                {
                    Console.WriteLine($"y({y}) не равен 0");
                }
                
                x += 0.2;
            }
        }
    }
}
