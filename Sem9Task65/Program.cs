// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.Write(prefix);
}


string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if(M>=N) return outRes+N;
    outRes = M+" "+RecMN(M+1,N);
    return outRes;

}

int number1 = ReadData("Введите число M; ");
int number2 = ReadData("Введите число N; ");
string resultLine = RecMN(number1,number2);
 PrintResult(resultLine);