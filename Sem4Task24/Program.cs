// Метод читает данные от пользователя
int ReadData(string line)
{   
    // Выводим сообщение
    Console.WriteLine(line);
    // считываеим число
    int numberP = int.Parse(Console.ReadLine()??"0");
    return numberP;// возвращаем значение
}

// Метод вывода данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for(int i = 1; i<=numA;i++)
    {
        sumOfNumbers+=i;
    }
    return sumOfNumbers;
}
int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1+numA)*numA)/2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А:");

DateTime d1 =DateTime.Now;
int res1 = VariantSumSimple( numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 =DateTime.Now;
int res2 =  VariantSumGause( numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от одного до А равна(простой метод):" +res1);
PrintResult("Сумма чисел от одного до А равна(простой Гаусса):" +res2);