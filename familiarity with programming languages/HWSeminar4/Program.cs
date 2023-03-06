/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* double Sum(double A, double B)
{
    double result = Math.Pow(A, B);
    return result;
}
double res = Sum(3, 5);   // А как эти значения ввести от пользовалеля с клавиатуры?
Console.WriteLine(res); */


/*Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/*int SumNum(int num)
{
    int num3 = num % 10;
    int num2 = num / 10 % 10;
    int num1 = num / 100;
    int result = num1 + num2 + num3;
    return result;
}
int res = SumNum(452);
Console.WriteLine(res); */


/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 10);
        //Console.Write($"{res[i]} ");
    }
    return res;
} 

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length ; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}
int[] array = GetArray(8);
PrintArray(array);





