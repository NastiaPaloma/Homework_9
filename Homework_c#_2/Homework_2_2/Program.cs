Console.WriteLine("Enter an integer number!");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0;
if (num > 99)
{
    while (num >= 1000)
    {
        num /= 10;
    }
    if (num >= 100 && num <= 999)
    {
        d = num % 10;
    }
    Console.WriteLine($"{d}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
