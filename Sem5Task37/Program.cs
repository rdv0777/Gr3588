int[] array = GenArray(123,-100,100);
PrintArray(array);
 Console.WriteLine();
int [] result = ConvertArr(array);
PrintArray(result);
 Console.WriteLine();

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

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] +"]");
}

int[] ConvertArr(int[] array)
{
    int[] outArr = new int[array.Length/2];
    for(int i=0; i<array.Length/2; i++)
    {
        outArr[i] = array[i]*array[array.Length-1 -i];
    }
      return outArr;
}