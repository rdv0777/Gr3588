int X1 = ReadData("Введите координату X1");
int X2 = ReadData("Введите координату X2");
int Y1 = ReadData("Введите координату Y1");
int Y2 = ReadData("Введите координату Y2");
int Z1 = ReadData("Введите координату Z1");
int Z2 = ReadData("Введите координату Z2");

double result = DstanceBetweenPoints(X1,Y1,X2,Y2,Z1,Z2);

PrintData("Расстояние между точками", result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод находит расстояние межу точками на плоскости
double DstanceBetweenPoints(double X1,double Y1,double Z1,double X2,double Y2,double Z2)
{
    double distance = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1));
    return distance;
}

// метод выводит данные пользователя
void PrintData(string msg, double res)
{
    Console.WriteLine(msg+res);
}


