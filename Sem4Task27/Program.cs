// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
// Метод вывода данных
void PrintData(int res)
{
    Console.WriteLine(res);
   
}
// Метод суммирования чисел
int SumDigit(int num)
{
   int res = 0;
   while(num>0)
   {
      res += num%10;
      num = num/10;
   }
   return res;
}


int num = ReadData("Введите число ");

int res = SumDigit(num);

PrintData(res);