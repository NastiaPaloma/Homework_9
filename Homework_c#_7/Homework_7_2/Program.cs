// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание,
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

bool CheckNumberIn(int number, int[,] array)
{
    bool find = false;
    foreach (int el in array)
    {
        if (el == number)
        {
            find = true;
            break;
        }
    }
    return find;
}

Console.WriteLine("Введите количетсво строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine(CheckNumberIn(number, array));