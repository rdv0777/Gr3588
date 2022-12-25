

// Метод вывода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Универсальный метод генерации и заполнения двумерного массива
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] =new Random().Next(min, max + 1);
        }
    }
}
//Универсальный метод печати двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
//Метод поиска элементов
void Chang2DArray(int[,] matr)
{
    int temp = 0; 
    for(int  i=0;i<matr.GetLength(1);i++)
    {
      temp = matr[0,i];
      matr[0,i] = matr[matr.GetLength(0)-1,i];
      matr[matr.GetLength(0)-1,i] = temp;
    }
}

int m=ReadData("Введите количество строк М: ");
int n=ReadData("Введите количество Столбцов N: ");
int[,] matrix = new int[m,n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);
Chang2DArray(matrix);
Console.WriteLine();
Print2DArray(matrix);