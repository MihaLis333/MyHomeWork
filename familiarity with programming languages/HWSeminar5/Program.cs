/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] FillArray (int Array)
{
    int[] res = new int[Array];
    for (int i = 0; i < Array; i++)
    {
        res[i] = new Random().Next(100, 999);
        //Console.Write($"{res[i]} ");
    }
    return res;
}
void PrintArray(int[] inArray)
{
    for(int ind = 0; ind < inArray.Length; ind++)
    {
        Console.Write($"{inArray[ind]} ");
    }
}
void EvenNumbers(int[] inArray)
{
    int count = 0;
    for(int index = 0; index < inArray.Length; index++)
    {
        if(inArray[index] % 2 == 0)
        {
            count++;
        }
        Console.Write($"{count} ");
    }
}
int[] iArray = FillArray(4);
PrintArray(iArray);
Console.WriteLine();
EvenNumbers(iArray);