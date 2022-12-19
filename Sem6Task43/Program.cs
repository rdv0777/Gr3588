double k1=ReadData("Введите k1: ");
double b1=ReadData("Введите b1: ");
double k2=ReadData("Введите k2: ");
double b2=ReadData("Введите b2: ");
double x =(b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;

PrintData("Пересечение в точке: x "+x+ " y "+y);

// Метод вывода данных
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()??"0");
}
//Метод выводящий на печать 
void PrintData(string res)
{
    Console.WriteLine(res);
}


