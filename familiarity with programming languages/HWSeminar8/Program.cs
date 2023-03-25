/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
int[,] GetsArray(int r, int c)
{
    int[,] result = new int[r, c];
    for(int i=0; i <r; i++)
    {
        for(int j=0; j <c; j++)
        {
            result[i, j] =new Random().Next(1, 10);
            //Console.Write($"{result[i,j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintsArray(int[,] psArray)
{
    for(int i=0; i <psArray.GetLength(0); i++)
    {
        for(int j=0; j <psArray.GetLength(1); j++)
        {
            Console.Write($"{psArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] ssArray)
{
  for (int i = 0; i < ssArray.GetLength(0); i++)
  {
    for (int j = 0; j < ssArray.GetLength(1); j++)
    {
      for (int k = 0; k < ssArray.GetLength(1) - 1; k++)
      {
        if (ssArray[i, k] < ssArray[i, k + 1])
        {
          int temp = ssArray[i, k + 1];
          ssArray[i, k + 1] = ssArray[i, k];
          ssArray[i, k] = temp;
        }
      }
    }
  }
}

int[,] sArray =GetsArray(4, 4);
PrintsArray(sArray);
Console.WriteLine();
SelectionSort(sArray);
PrintsArray(sArray); */

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
int[,] GetsArray(int r, int c)
{
    int[,] result = new int[r, c];
    for(int i=0; i <r; i++)
    {
        for(int j=0; j <c; j++)
        {
            result[i, j] =new Random().Next(1, 10);
            //Console.Write($"{result[i,j]} ");
        }
        //Console.WriteLine();
    }
    return result;
}

void PrintsArray(int[,] pArray)
{
    for(int i=0; i <pArray.GetLength(0); i++)
    {
        for(int j=0; j <pArray.GetLength(1); j++)
        {
            Console.Write($"{pArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumString(int[,] sArray)
{
    int sum =int.MaxValue;
    int index =0;
    for(int i =0; i < sArray.GetLength(0); i++)
    {
        int sumLine = sArray[i,0];
        for (int j = 1; j < sArray.GetLength(1); j++)
        {
            sumLine += sArray[i,j];
            
        }
        Console.Write($"{sumLine} ");
        if(sumLine < sum)
        {
            sum = sumLine;
            index = i;
        }
    }
    Console.WriteLine();
        for(int i =0; i < sArray.GetLength(1); i++)
        {
            Console.Write($"{sArray[index, i]} ");
        }
}

int[,] array =GetsArray(3, 4);
PrintsArray(array);
Console.WriteLine();
SumString(array); */
