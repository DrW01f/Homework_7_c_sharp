// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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

double[,] GetArray(int[] array)
{
    double[,] twodimensionalArray = new double[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {   //для создания отрицательных чисел использовал new Random().Next(-10, 11)
            twodimensionalArray[i, j] = Math.Round((new Random().NextDouble() *
            Math.Pow(10, new Random().Next(0, 3)) * new Random().Next(-10, 11)), 2);
        }
    }
    return twodimensionalArray;
}

void PrintArray(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();
    int[] arrayRowCol = InputFunc();
    double[,] array = GetArray(arrayRowCol);
    PrintArray(array);
}

Main();
