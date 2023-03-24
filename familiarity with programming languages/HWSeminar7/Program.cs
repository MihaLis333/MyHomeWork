/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*double[,] GetArray(int r, int c)
{
    double[,] result = new double[r, c];
    Random rand = new Random();
    for(int i =0; i < r; i++)
    {
        for(int j =0; j <r; j++)
        {
            result[i,j] = Math.Round(rand.Next(-10, 11)* 0.1, 1);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}
double[,] array = GetArray(4, 4); */


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> по данным индексам такого числа в массиве нет
*/

/*Console.Write("Enter the position element of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the position element of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] numbers = new int [4,4];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) && m > numbers.GetLength(1))
{
    Console.WriteLine(" ----> No such position. ");
}
else
{
    Console.WriteLine($" ----> Element value {n} string and {m} column equals {numbers[n-1,m-1]}. ");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
} */

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int r, int c)
{
    int[,] result =new int[r, c];
    for(int i =0; i< r; i++)
    {
        for(int j=0; j< c; j++)
        {
            result[i, j] = new Random().Next(1, 10);
            //Console.Write($"{result[i, j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintArray(int[,] pArray)
{
    for(int i =0; i< pArray.GetLength(0); i++)
    {
        for(int j=0; j< pArray.GetLength(1); j++)
        { 
          Console.Write($"{pArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageArray(int[,] aArray)
{
    //int[,] num = new int[r, c];
    //int sum = 0;
    for(int cj =0; cj < aArray.GetLength(1); cj++)
    {
        double sum =0;
        for(int ri =0; ri < aArray.GetLength(0); ri++)
        {
            sum = sum + aArray[ri, cj];   
        }
        sum = sum / aArray.GetLength(1);//aArray.GetLength(1);
        Console.Write(sum + ", ");
    }

}


int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
AverageArray(array);