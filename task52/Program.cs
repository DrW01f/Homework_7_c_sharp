// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[] InputFunc()
{
    int[] parametrs = new int[2];
    Console.WriteLine("Введите кол-во строк");
    int row = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во столбцов");
    int col = int.Parse(Console.ReadLine()!);
    parametrs[0] = row;
    parametrs[1] = col;
    return parametrs;
}

int[,] GetArray(int[] parametrs, int minValue = -10, int maxValue = 10)
{
    int[,] result = new int[parametrs[0], parametrs[1]];
    for (int i = 0; i < parametrs[0]; i++)
    {
        for (int j = 0; j < parametrs[1]; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void AverageFind(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        double summ = 0; // С каждой задачей питон кажется все более идеальным языком, если 
//результат деления автоматом не ставится как double(float) >=(
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        avarage = summ / array.GetLength(0);
        Console.Write($"{avarage:F2}; ");
    }
}


void Main()
{
    Console.Clear();
    int[] arrayRowCol = InputFunc();
    int[,] array = GetArray(arrayRowCol);
    PrintArray(array);
    AverageFind(array);
}

Main();