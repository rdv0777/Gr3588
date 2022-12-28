
int a = ReadData("Введите количество строк 1-й матрицы" + "  ");
int b = ReadData("Введите количество столбцов 1-й матрицы (и строк 2-й матрицы)" + "  ");
int c = ReadData("Введите количество столбцов 2-й матрицы" + "  ");
int[,]  firstMartrix = new int[a,  b];
int[,] arr2D = Fill2DArray(a,  b, 0, 99);
Console.WriteLine();
int[,] secomdMartrix = new int[b,c];
int[,] arr2D2 = Fill2DArray( b,c, 0, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();
Print2DArrayColor(arr2D2);


int[,]  resultMatrix = new int[a,c];

MultiplyMatrix(arr2D, arr2D2, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
Print2DArrayColor(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
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
            Console.Write(matrix[i, j] + "       ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

