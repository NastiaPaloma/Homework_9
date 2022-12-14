//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]},");
    Console.WriteLine();
}


int FindSumsOddNumbers(int[] array)
{
    int sum = 0;
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
            if (i % 2 != 0)
                sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine(FindSumsOddNumbers(array));
