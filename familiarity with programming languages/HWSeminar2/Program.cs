/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/*Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32 (Console.ReadLine());

int doz = num / 10 % 10;

if(num > 99 || num < 999)
{
    Console.WriteLine(doz);
}
if (num < 99 || num > 999)
{
    Console.WriteLine("Это не трехзначное число!");
} */


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/*int thNum(int num)
{
    if (num > 99)
    {
        int ed = num % 10;
        Console.WriteLine(ed);
    }
    else 
    {
        Console.WriteLine("Введите трехзначное число!");
    }   
    return num;
}
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
thNum(num); */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* Console.WriteLine("введите цифру дня недели");
int day = Convert.ToInt32 (Console.ReadLine());
int n = day;
int weekend1 = 6;
int weekend2 = 7;

if (day == weekend1 || day == weekend2)
{
    Console.WriteLine("Выходной день");
}
if (day > 7)
{
    Console.WriteLine("Такого дня недели - НЕТ!");
}
if (day < 6)
{
    Console.WriteLine("Будний день");
} */





