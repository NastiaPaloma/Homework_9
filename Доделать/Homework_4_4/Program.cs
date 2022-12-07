//HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
//452 -> 3, 82 -> 2, 9,012 ->4
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (num > 0)
{
        num = num / 10;
        i++;
}
Console.WriteLine($"{i}");
//double num2 = Convert.ToDouble(Console.ReadLine());
//double i2 = 0;
//num = num * 1000;