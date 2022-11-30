Console.WriteLine("Введите трехзначное число!");
int num = Convert.ToInt32(Console.ReadLine());
while(num >= 100)
{
    num /= 10;
}
int d = num % 10;

Console.WriteLine($"{d}");