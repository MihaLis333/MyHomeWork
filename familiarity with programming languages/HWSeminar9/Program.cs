/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// void Concequense(int n)
// {
//     if(n !=0)
//     {
//         Console.Write($"{n}, ");
//         Concequense(n-1);
//     }
// }

// Console.Write("Input number: ");
// int N = int.Parse(Console.ReadLine());
// Concequense(N);


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


// int SumElements(int n, int m)
// {
//   if (n == m) return n;
//   else return SumElements(n + 1, m) + n;
// }

// Console.Write("Input number N: ");
// int N = int.Parse(Console.ReadLine());

// Console.Write("Input number M: ");
// int M = int.Parse(Console.ReadLine());

// Console.WriteLine($"Sum elemnts {N} and {M} = {SumElements(N, M)}");


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input number M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
