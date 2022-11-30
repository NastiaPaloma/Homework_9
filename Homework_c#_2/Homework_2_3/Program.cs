Console.WriteLine("Введите день недели от 1 до 7!");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7)
{
    Console.WriteLine("Это выходной день");
} 
else
{
    Console.WriteLine("Это будний день");
}