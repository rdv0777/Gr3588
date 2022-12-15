int[] array = GenArray(123,-100,100);
PrintArray(array);

int result = CountElement(array,10,99);
PrintData("Колличество элементов массива, значения которых лежат в отрезке 10,99 составляет ",result);

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd =new Random(); //создали массив
    int[] arr = new int[len]; //Создали массив 
    for (int i = 0; i < arr.Length; i++)  //Мин макс значение
    {                                              //Проходим по массиву заполняем его 
        arr[i] = rnd.Next(minValue, maxValue +1);
    }
    return arr; //Выдаем результат
}
void PrintData(string res, int value)
{
    Console.WriteLine(res+value);
}
void PrintArray (int[] arr)
{
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1]);
}

int CountElement(int[] array, int min, int max)
{
    int res = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>min && array[i]<max)
        {
            res++;
        }
      
    }
      return res;
}