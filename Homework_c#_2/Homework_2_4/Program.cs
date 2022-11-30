Console.WriteLine("Введите число от 1 до 100!");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 3 == 0)Console.WriteLine($"Fizz");
if (num % 5 == 0) Console.WriteLine($"Buzz");
//if (num % 3 == 0 && num % 5 == 0) Console.WriteLine($"FizzBuzz");
