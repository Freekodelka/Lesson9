﻿/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


void PrintNatural(int N)
{
    if (1 <= N)
    {
        Console.WriteLine(N);
        PrintNatural(N - 1);
    }
}
Console.Write("Введите число N:  ");
int number = int.Parse(Console.ReadLine());
PrintNatural(number);






