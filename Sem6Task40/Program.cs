
int a = ReadData("Введите первое число");
int b = ReadData("Введите второе число");
int c = ReadData("Введите третье число");

if(TriageleTest(a,b,c)) PrintData("Может существовать треугольник со сторонами такой длины.");
else PrintData("Треугольник со сторонами такой длины не существует.");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//Метод выводящий на печать данные пользователя
void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriageleTest(int a, int b, int c)
{
    return((a+b>c)&&(a+c>b)&&(b+c>a));
}