// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] GetArray(int[] parametrs, int minValue = -50, int maxValue = 50)
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

string FindElement(int[,] array)
{
    Console.WriteLine("Введите номер строки: ");
    int i = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца: ");
    int j = int.Parse(Console.ReadLine()!);
    // if(i < array.GetLength(0) && i < array.GetLength(1))
    // {
    //     return array[i,j].ToString();
    // }
    // else return "Такого элемента нет";
    return (i <= array.GetLength(0) && j <= array.GetLength(1)) ? ("Искомый элемент: " + array[i - 1, j - 1].ToString()) : "Такого элемента нет";
}

void Main()
{
    Console.Clear();
    int[] arrayRowCol = InputFunc();
    int[,] array = GetArray(arrayRowCol);
    PrintArray(array);
    string answer = FindElement(array);
    Console.WriteLine(answer);
}

Main();