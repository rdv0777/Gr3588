
//Задача 67 
// Принимает на вход число и возвращает сумму числа

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
  
}

// Печать результата
void PrintResult(int prefix)
{
    Console.Write(prefix);
}


int RecSumDig(int n)
{
   
    if(n<=10) return n;
    int result = n%10+RecSumDig(n/10);
    return result;

}


int number = ReadData("Введите число N; ");
int resultLine = RecSumDig(number);
 PrintResult(resultLine);