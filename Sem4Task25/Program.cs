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
// Метод возведения в степень
int Pow(int A, int B)
{
   int res = 1;
   for(int i = 1; i <= B; i++)
   {
      res = A*res;
   }
   return res;
}


int numA = ReadData("Введите число A");

int numB = ReadData("Введите число B");

int res = Pow(numA, numB);

PrintData(res);