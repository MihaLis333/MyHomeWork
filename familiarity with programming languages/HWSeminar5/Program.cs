/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/*int[] FillArray (int Array)
{
int[] res = new int[Array];
    for (int i = 0; i < Array; i++)
    {
        res[i] = new Random().Next(100, 999);
        //Console.Write($"{res[i]} ");
    }
    return res;
}
void PrintArray (int[] inArray)
{
    for (int ind = 0; ind < inArray.Length; ind++)
    {
        Console.Write($"{inArray[ind]} ");
    }
}
void EvenNumbers (int[] inArray)
{
int count = 0;
    for (int index = 0; index < inArray.Length; index++)
    {
        if(inArray[index] % 2 == 0)
        {
            count++;
        }   
    }
    Console.Write($"{count} ");
}
int[] iArray = FillArray(4);
PrintArray(iArray);
Console.WriteLine();
EvenNumbers(iArray); */


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/*int[] FillArray (int Array)
{
int[] res = new int[Array];
    for (int i = 0; i < Array; i++)
    {
        res[i] = new Random().Next(1, 10);
        //Console.Write($"{res[i]} ");
    }
    return res;
}
void PrintArray (int[] pArray)
{
    for (int pi = 0; pi < pArray.Length; pi++)
    {
        Console.Write($"{pArray[pi]} ");
    }
}

void SumElements (int[] sArray)
{
int numodd = 0;
int numeven = 0;
    foreach (int element in sArray)
    {
        if (element % 2 != 0)
        {
            numodd += element;
        }
        else
        {
            numeven += element;
        }
    }
    Console.WriteLine($"{numodd}");
}
int[] array = FillArray(4);
PrintArray(array);
Console.WriteLine();
SumElements(array); */


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 
*/

int[] FillArray (int fArray)
{
int[] res = new int[fArray];
    for (int i = 0; i < fArray; i++)
    {
        res[i] = new Random(). Next (1, 10);
    }
    return res;
}

void PrintArray (int[] pArray)
{
    for (int pI = 0; pI < pArray.Length; pI++)
    {
        Console.Write($"{pArray[pI]} ");
    }
}

void DiffElement (int[] dElement)
{
    int maxNum = 0;
    //int index = 0;
    //int minNum = 1;
    for (int dI = 0; dI < dElement.Length; dI++)
    {
        if (dElement[dI] > maxNum) 
        {
             maxNum = dElement[dI];
        }
        Console.WriteLine($"{maxNum}");
    }
   
   
}

int[] Array = FillArray(5);
PrintArray(Array); 
Console.WriteLine();
DiffElement(Array);
