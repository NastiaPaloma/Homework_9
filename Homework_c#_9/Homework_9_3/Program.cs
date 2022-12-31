// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9  m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число M: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
uint n = Convert.ToUInt32(Console.ReadLine());

uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
Console.WriteLine("Функция Аккермана равна: ");
Console.WriteLine(A(m , n));