﻿
// Метод вывода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Универсальный метод генерации и заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}
//Универсальный метод печати двумерного массива
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]
{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
//Метод нахождения строки с наименьшей суммой элементов
int MinRow(int[,] arr)
{
    int minIndex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (minRow < sum) minRow = sum; minIndex = i;
    }
    return minIndex;
}

int row = ReadData("Введите количество строк" + "  ");
int column = ReadData("Введите количество столбцов" + "  ");
int[,] arr2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(arr2D);

Console.WriteLine();
int minIndex = MinRow(arr2D);
Console.WriteLine("Строка с наименьшей суммой элементов №" + minIndex);
