
int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int page = ReadData("Введите количество страниц");

List<int> num=new List<int>();
for(int i=0;i<99;i++)
{
    num.Add(10+i);
}

int[,,] arr3D = Fill3DArray(row, column, page, num);
Print3DArrayColor(arr3D);

int GenNum(List<int>num)
{
    int index=new Random().Next(0,num.Count);
    int outNum=num[index];
    num.RemoveAt(index);
    return outNum;
}
// Метод вывода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Универсальный метод генерации и заполнения двумерного массива
int[,,] Fill3DArray(int countRow, int countColumn, int countPage,  List<int> num)
{
    int[,,] array3D = new int[countRow, countColumn, countPage];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countPage; k++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}
//Универсальный метод печати двумерного массива
void Print3DArrayColor(int[,,] matrix)
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
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.ForegroundColor = col[matrix[i, j,k] % 15];
            Console.Write(matrix[i, j, k] + "     ".Substring(matrix[i, j, k].ToString().Length));
            Console.ResetColor();
            }
            Console.WriteLine();
        }       
    }
}

