Console.WriteLine("Введите количество программистов от 1 до 1000!");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1 || num % 10 == 1 || num % 100 == 1)
{
    Console.WriteLine($"{num} программист");
}
else if (num == 2 || num == 4 || num % 10 == 2 || num % 100 == 2 || num % 10 == 4 || num % 100 == 4 || num == 3 || num % 10 == 3 || num % 100 == 3)
{
    Console.WriteLine($"{num} программиста");
}
else
{
    Console.WriteLine($"{num} программистов");
}
