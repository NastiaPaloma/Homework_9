//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵), 2, 4 -> 16

Console.WriteLine("Введите число А");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Pr(num)}");
int Pr (int n)
{
int i = 0;
int p = 1;
while (i < num2)
{
    p = p * num;
    i ++;
}
return p;
}