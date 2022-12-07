//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11, 82 -> 10, 9012 -> 12

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Summa(n)}");
int Summa (int n)
{
int sum = 0;
int d = 0;
while (n > 0)
{
    d = n % 10;
    sum = sum + d;
    n /= 10;
}
return sum;
}
