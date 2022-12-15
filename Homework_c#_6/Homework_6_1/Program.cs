//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2, 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int num = rand.Next(-100, 1000);
        array[i] = num;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

int FindCountPositiveNumbers(int[] array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (array[i] > 0)
            count = count + 1;
    return count;
}

Console.WriteLine("Введите M числа");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
Console.WriteLine(FindCountPositiveNumbers(array));