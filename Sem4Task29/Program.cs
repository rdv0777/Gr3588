int arrLen = ReadData("Введите длину массива");

int num1 = ReadData("Введите наименьшее число массива");

int num2 = ReadData("Введите наибольшее число массива");

int[] arr = GenArr(arrLen);

PrintData("Сгенерированный массив: ",arr);


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int num)
{
    Random rnd =new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(num1,num2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


