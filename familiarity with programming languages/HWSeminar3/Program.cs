/*Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.Write("Input number: ");
double num = int.Parse(Console.ReadLine());

for (double i = 1; i <= num; i++)
{
    double quatro = i * i * i;
    Console.WriteLine(quatro);
} */

/*Задача 21. Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*Console.Write("Input coordinat point Xa: ");
double xa = int.Parse(Console.ReadLine());
Console.Write("Input coordinat point Ya: ");
double ya = int.Parse(Console.ReadLine());
Console.Write("Input coordinat point Za: "); 
double za = int.Parse(Console.ReadLine());

Console.Write("Input coordinat point Xb: ");
double xb = int.Parse(Console.ReadLine());
Console.Write("Input coordinat point Yb: "); 
double yb = int.Parse(Console.ReadLine());
Console.Write("Input coordinat point Zb: "); 
double zb = int.Parse(Console.ReadLine());

double ac = Math.Pow(xb - xa, 2); 
double bc = Math.Pow(yb - ya, 2);
double zz = Math.Pow(zb - za, 2); 

//double ac2 = Math.Pow(ac, 2); 
//double bc2 = Math.Pow(bc, 2);
Console.WriteLine($"{Math.Sqrt(ac + bc + zz)}"); */


/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/*Console.Write("Input five-digit number: ");
int num = int.Parse(Console.ReadLine());

int num5 = num % 10;
int num4 = num % 100 / 10;
int num2 = num / 1000 % 10; 
int num1 = num / 10000; 


if (num1 == num5 && num2 == num4)
{
   Console.WriteLine("Palindrom"); 
}
else
{
  Console.WriteLine("Not Palindrom");
} */


