//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии

// Метод ввода данных
long ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}


long RecPow(long a, long b)
{
    if(b<=1) return a;
    return a* RecPow(a,b-1);
}

long MyPow (long a, long b)
{
    if(b==2)return a*a;
    if(b==1)return a;

    if(b%2==0)
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a,b/2+1);
    }
}

long number1 = ReadData("Введите число a; ");
long number2 = ReadData("Введите число b; ");


long result = MyPow(number1,number2);
PrintResult(result);

long result2 = RecPow(number1,number2);
PrintResult(result2);

