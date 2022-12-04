//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
//Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.WriteLine("Введите размерность пространства: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A: ");
int [] arrayA = new int[n];
for (int i = 0; i < n; i++) arrayA[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int [] arrayB = new int[n];
for (int j = 0; j < n; j++) arrayB[j] = Convert.ToInt32(Console.ReadLine());
