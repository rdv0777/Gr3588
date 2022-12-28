
// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.Write(prefix);
}

//Рекурентный метод суммирования чисел
int SumMNRec(int M, int N)
{
    if(M>=N)return N;
    return M+SumMNRec(M+1,N);
}

int number1 = ReadData("Введите число M; ");
int number2 = ReadData("Введите число N; ");
int resultLine = SumMNRec(number1,number2);
 PrintResult(resultLine);