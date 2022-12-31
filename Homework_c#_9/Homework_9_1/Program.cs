// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"   N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"числа от N до 1: {NumbersRec(n)}");

string NumbersRec(int N)
{
    if (N == 0) return " ";
    return N + " " + NumbersRec(N - 1);
}

