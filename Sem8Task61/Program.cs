
//Вычисляем факториал
float Factor(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

// Метод вывода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintPascalTiangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        //Создаём после каждой строки n-i отступов от левой стороны консоли,
        //чем ниже строка, тем меньше отступ
        for (int j = 0; j <= (nRow - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            //Создаём пробелы между элементами треугольника
            Console.Write(" ");
            //формула вычисления элементов треугольника 
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRow = ReadData("Введите количество строк треугольнмка Паскаля: ");

PrintPascalTiangle( countRow );