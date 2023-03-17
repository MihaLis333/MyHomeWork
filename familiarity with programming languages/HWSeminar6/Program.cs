/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*double[] GetArray()
{
    Console.Write("Input element array: ");

    double elementCount = double.Parse(Console.ReadLine());

    double[] MArray = new double [elementCount];

    for (double i =0; i < MArray.Length; i++)
    {
        Console.Write($"\nInput element array in index {i}:\t ");
        MArray[i] = double.Parse(Console.ReadLine());
    }

    for(double i = 0; i < MArray.Length; i++)
    {
        
        Console.Write($"\n{MArray[i]}");
    }
    return MArray;
}

void OutNum(double[] numbers)
{ 
    double count = 0;

    for(double i =0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            count++;   
        }       
    }
     Console.Write($"{count}");
} 
double[] array = GetArray();
Console.WriteLine();
OutNum(array); */

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void LinePoint(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine($"two lines intersect X: {x}, Y: {y}");
}
Console.WriteLine("Input foure line point");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());
double num4 = double.Parse(Console.ReadLine());
LinePoint(num1, num2, num3, num4);