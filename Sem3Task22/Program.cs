// int X1 = ReadData("Введите координату X1");
// int X2 = ReadData("Введите координату X2");
// int Y1 = ReadData("Введите координату Y1");
// int Y2 = ReadData("Введите координату Y2");

// double result = DstanceBetweenPoints(X1,Y1,X2,Y2);

// PrintData("Расстояние между точками", result);

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

// // Метод находит расстояние межу точками на плоскости
// double DstanceBetweenPoints(double X1,double Y1,double X2,double Y2)
// {
//     double distance = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2));
//     return distance;
// }

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }
int number = ReadData("Введите число: ");

string outLine = LineBilder(number, 1);
PrintData("",outLine);
outLine = LineBilder(number, 2);
PrintData("",outLine);

// Метод вывода данных
void PrintData(string msg, string res)
{
    Console.WriteLine(msg+res);
}

// Метод сборки строки
string LineBilder(int n, int pow)
{
    string line = string.Empty;
    for(int i=1; i<n; i++)
    {
        line = line + Math.Pow (i, pow)+" ";
    }
    line = line + Math.Pow(n,pow);
    return line;
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}


