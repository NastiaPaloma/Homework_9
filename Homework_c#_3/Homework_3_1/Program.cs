//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//14212 -> нет, 12821 -> да, 23432 -> да

Console.WriteLine("Введите пятизначное число!");
int num = Convert.ToInt32(Console.ReadLine());

if ((num / 10000) == (num % 10))
{
    num = (num/10) % 1000;
}
if ((num / 100) == (num % 10))
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}
