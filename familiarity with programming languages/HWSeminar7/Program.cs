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


Console.Write("Enter the position element of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter the position element of columns: ");
int columns = int.Parse(Console.ReadLine());


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

void SearhElement(int[,] sArray)
{
    //int result =0;
    for(int ri =0; ri < sArray.GetLength(0); ri++) 
    {
        for(int cj =0; cj < sArray.GetLength(1); cj++) 
        {
            if(ri == rows && cj == columns)
            {
               Console.WriteLine($"{sArray[ri, cj]}");//=  (rows, columns);
            }
            else
            {
                Console.WriteLine("There is no such number in the array");
            }
        }
    }
    //return result;

}


int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
SearhElement(array);
//Console.WriteLine($"{SearhElement(array)}");





