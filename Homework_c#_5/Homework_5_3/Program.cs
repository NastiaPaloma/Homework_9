//Задайте массив случайных вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(0, 100);
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

int[] FindDiff(int[] array)
{
    int max = array[0];
    int min = array[0];
    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int[] result = { max, min };
    return result;
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int[] Diff = FindDiff(array);
Console.WriteLine($"{Diff[0]}"); // вывод max элемента
Console.WriteLine($"{Diff[1]}"); // вывод min элемента
Console.WriteLine($"Разница максимального и минимального элементов: " + (Diff[0] - Diff[1]));
