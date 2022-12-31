// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120   M = 4; N = 8. -> 30


Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от {m} до {n} равна {SummaRec(n)}");

int SummaRec(int n)
{
    if (m > n) return 0;
    return n + SummaRec(n - 1);
}