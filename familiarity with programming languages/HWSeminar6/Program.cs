/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] Main(string[] args)
{
    Console.Write("Input element array: ");

    int elementCount = int.Parse(Console.ReadLine());

    int[] MArray = new int [elementCount];

    for (int i =0; i < MArray.Length; i++)
    {
        Console.Write($"\nInput element array in index {i}:\t ");
        MArray[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 0; i < MArray.Length; i++)
    {
        
        Console.Write($"\n{MArray[i]}");
    }
    return MArray;
}

void OutNum(string num)
{ 
    int n = Convert.ToInt32(num);
    int[] OArray = new int[n];

    for(int i =0; i < OArray.Length; i++)
    {
        if(OArray[i] > 0)
        {
            Console.Write(OArray[i]);
        }
    }
} 
Main(args);
OutNum(args);