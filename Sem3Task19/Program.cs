
int num = ReadData("Введите пятизначный полиндром: ");

bool res = PalinTest(num);

PrintData(res);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

bool PalinTest(int num)
{
    bool res =false;
    res = (num/10000==num%10)&&((num/100)%10==(num/10)%10);
    return res;
}


// Метод вывода данных
void PrintData( bool res)
{
    Console.WriteLine(res);
}




