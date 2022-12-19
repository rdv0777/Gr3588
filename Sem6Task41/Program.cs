
Console.Write("Введите элементы(через пробел):");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
PrintData(CountPosNum(arr));


//Метод выводящий на печать 
void PrintData(int res)
{
    Console.WriteLine( "Колличество чисел больше 0: "+res);
}

//Метод нахождения положительных чисел
int CountPosNum(int[] num)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
