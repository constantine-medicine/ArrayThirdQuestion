using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayThirdQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Задача №1
            //// Программа, умножающая математическую матрицу на число

            //int[,] arr = NewMethod();

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write("\nВведите число, на которое умножить матрицу: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\nМатрица, после умножения на число: ");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] *= number;
            //        Console.Write("{0, 6}", arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();




            //// Задача № 3.1
            //// Программа сложения и вычитания матриц

            //int counter = 1;
            //int[,] arrFirst = new int[0, 0];
            //int[,] arrSecond = new int[0, 0];

            //while (counter < 3)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;

            //    Console.Write($"\nВведите количество строк {counter} матрицы: ");
            //    int row = int.Parse(Console.ReadLine());

            //    Console.Write($"\nВведите количество столбцов {counter} матрицы: ");
            //    int col = int.Parse(Console.ReadLine());

            //    if (counter == 1)
            //    {
            //        arrFirst = new int[row, col];
            //        counter++;
            //    }
            //    else
            //    {
            //        arrSecond = new int[row, col];
            //        counter++;
            //    }

            //    if (counter == 3)
            //    {
            //        if (arrFirst.GetLength(0) != arrSecond.GetLength(0) || arrFirst.GetLength(1) != arrSecond.GetLength(1))
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Матрицы разной размерности! Повторите ввод! ");
            //            counter -= 2;
            //        }
            //    }
            //}
            //Console.Clear();

            //Random rand = new Random();

            //Console.WriteLine("\nПервая матрица после заполнения случайными числами: ");

            //for (int i = 0; i < arrFirst.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrFirst.GetLength(1); j++)
            //    {
            //        arrFirst[i, j] = rand.Next(1, 101);
            //        Console.Write("{0, 6}", arrFirst[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nВторая матрица после заполнения случайными числами: ");

            //for (int i = 0; i < arrSecond.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrSecond.GetLength(1); j++)
            //    {
            //        arrSecond[i, j] = rand.Next(1, 101);
            //        Console.Write("{0, 6}", arrSecond[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("Вычитание или сложение нужно выполнить? Введите знак + или -: ");
            //string sign = Convert.ToString(Console.ReadLine());

            //while (true)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;

            //    if (sign == "+")
            //    {
            //        Console.WriteLine("Матрица сложения двух матриц: ");

            //        for (int i = 0; i < arrFirst.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arrFirst.GetLength(1); j++)
            //            {
            //                Console.Write("{0, 6}", arrFirst[i, j] += arrSecond[i, j]);
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    }

            //    else if (sign == "-")
            //    {
            //        Console.WriteLine("Матрица вычитания двух матриц: ");

            //        for (int i = 0; i < arrFirst.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < arrFirst.GetLength(1); j++)
            //            {
            //                Console.Write("{0, 6}", arrFirst[i, j] -= arrSecond[i, j]);
            //            }
            //            Console.WriteLine();
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Повторите ввод!");

            //        Console.ForegroundColor = ConsoleColor.White;
            //        sign = Convert.ToString(Console.ReadLine());
            //    }
            //}




            // Задача №3.2
            // Умножение матриц

            //Console.WriteLine("Уможение матриц");
            //System.Threading.Thread.Sleep(1000);

            //int counterMatrix = 1;
            //int row = 0;
            //int column = 0;
            //int[,] firstMatrix = new int[row, column];
            //int[,] secondMatrix = new int[row, column];

            //while (counterMatrix < 3)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;

            //    Console.Write($"\nВведите количество строк {counterMatrix} матрицы: ");
            //    row = int.Parse(Console.ReadLine());

            //    Console.Write($"\nВведите количество столбцов {counterMatrix} матрицы: ");
            //    column = int.Parse(Console.ReadLine());

            //    if (counterMatrix == 1)
            //    {
            //        firstMatrix = new int[row, column];
            //        counterMatrix++;
            //    }
            //    else
            //    {
            //        secondMatrix = new int[row, column];
            //        counterMatrix++;
            //    }

            //    if (counterMatrix == 3)
            //    {
            //        if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Данные матрицы перемножить нельзя! Повторите ввод!");
            //            counterMatrix -= 2;
            //        }
            //    }

            //}

            //Random rand = new Random();
            //Console.WriteLine("Первая матрица: ");

            //for (int i = 0; i < firstMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstMatrix.GetLength(1); j++)
            //    {
            //        firstMatrix[i, j] = rand.Next(10);
            //        Console.Write("{0, 3}", firstMatrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Вторая матрица: ");

            //for (int i = 0; i < secondMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < secondMatrix.GetLength(1); j++)
            //    {
            //        secondMatrix[i, j] = rand.Next(10);
            //        Console.Write("{0, 3}", secondMatrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            //for (var i = 0; i < firstMatrix.GetLength(0); i++)
            //{
            //    for (var j = 0; j < secondMatrix.GetLength(1); j++)
            //    {
            //        resultMatrix[i, j] = 0;

            //        for (var k = 0; k < firstMatrix.GetLength(1); k++)
            //        {
            //            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            //        }
            //    }
            //}

            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Матрица после умножения двух матриц: ");

            //for (int i = 0; i < resultMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resultMatrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0, 6}", resultMatrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadKey();

            Console.Write("Введите никнейм 1го игрока: ");
            string firstName = Convert.ToString(Console.ReadLine());

            Console.Write("Введите никнейм 2го игрока: ");
            string secondName = Convert.ToString(Console.ReadLine());

            Random rand = new Random();
            int gameNumber = rand.Next(12, 121);

            Console.WriteLine($"Загаданное число: {gameNumber}");

            int counterUser = 1;

            int userTry = 0;

            while (true)
            {
                if (counterUser % 2 != 0)
                {
                    Console.WriteLine($"Ход игрока {firstName}");
                }
                else if (counterUser % 2 == 0)
                {
                    Console.WriteLine($"Ход игрока {secondName}");
                }

                userTry = int.Parse(Console.ReadLine());
                counterUser++;

                if (userTry < 1 || userTry > 4)
                {
                    Console.WriteLine("Играйте по правилам! Повторите ввод!");
                    counterUser--;
                }
                else
                {
                    gameNumber -= userTry;
                    Console.WriteLine($"Получилось число {gameNumber}");
                }

                if (gameNumber <= 0 && counterUser % 2 == 0)
                {
                    Console.WriteLine($"Победил игрок {firstName}");
                    break;
                }

                else if (gameNumber <= 0 && counterUser % 2 != 0)
                {
                    Console.WriteLine($"Победил игрок {secondName}");
                    break;
                }
            }


            Console.ReadKey();
        }

    }

}

        //private static int[,] NewMethod()
        //{
        //    Console.Write("\nВведите количество строк матрицы: ");
        //    int row = int.Parse(Console.ReadLine());

        //    Console.Write("\nВведите количество столбцов матрицы: ");
        //    int col = int.Parse(Console.ReadLine());

        //    Console.WriteLine("\nПолученная матрица");

        //    int[,] arr = new int[row, col];
        //    Random rand = new Random();

        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            arr[i, j] = rand.Next(1, 100);
        //            Console.Write("{0, 6}", arr[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    return arr;
        //}
