int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int number = ReadData("Введити число а");
int length = VariantLog(number);
PrintData("количество цифр в числе равно " + length);

