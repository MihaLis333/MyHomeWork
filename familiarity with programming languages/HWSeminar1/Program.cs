﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

int a = 5;
int b = 7;

int max = b;

if (a > max) max = a;
if (b > max) max = b;

Console.WriteLine(max); */


/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

int a = 2;
int b = 3;
int c = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max); */


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет 

int a = 3;

if (a % 2 == 0)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
} */


/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 

int N = 5;

int count = 0;

while (count <= N )
{
    if (count % 2 == 0)
    {
        Console.Write(count);      
    }
    count++;
}  */




