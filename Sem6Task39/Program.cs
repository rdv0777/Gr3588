
int[] arr = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый массив перевёрнутый SwapNewArray методом");
Print1DArr(copyArr);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Исходный массив");
Print1DArr(arr);
Console.WriteLine("Новый массив перевёрнутый SwapArray методом ");
Print1DArr(copyArrTwo);
//Метод генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random(); //создали массив
    int[] arr = new int[len]; //Создали массив 
    for (int i = 0; i < arr.Length; i++)  //Мин макс значение
    {                                              //Проходим по массиву заполняем его 
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr; //Выдаем результат
}
//Метод выводящий на печать данные пользователя
void PrintData(string res, int value)
{
    Console.WriteLine(res+value);
}
//Метод выводящий на печать массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
//Метод, считывающий данные, введённые пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");
// }

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

