int k1=ReadData("Введите k1: ");
int b1=ReadData("Введите b1: ");
int k2=ReadData("Введите k2: ");
int b2=ReadData("Введите b2: ");
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

PrintData("Пересечение в точке: x "+x+ " y "+y);

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//Метод выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
}


