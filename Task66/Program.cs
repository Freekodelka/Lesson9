/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */


int SumNumber(int n, int m)
{
    if (m < n)
    {
        return 0;
    }
    else
    {
        return n + SumNumber(n + 1, m); 
    }
    
}
Console.Write("Введите число n:  ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m:  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1} равна {2}", n, m, SumNumber(n,m));

