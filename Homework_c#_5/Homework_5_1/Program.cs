// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(100, 1000);
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

int FindCountEvenNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (array[i] % 2 == 0 && i < size)
            count = count + 1;
    return count;
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.WriteLine(FindCountEvenNumbers(array));