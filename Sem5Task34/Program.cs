int[] array = GenArray(123,100,999);
Print1DArr(array);
 Console.WriteLine();
int result = CountEven(array);
PrintData(result);

//создали массив заполненный случайными  числами
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd =new Random(); 
    int[] arr = new int[len]; 
    for (int i = 0; i < arr.Length; i++)  
    {                                             
        arr[i] = rnd.Next(minValue, maxValue +1);
    }
    return arr; 
}
// выводим сгенерированный массив
void Print1DArr (int[] arr)
{
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1]);
}
//выводим результат
void PrintData(int res)
{
    Console.WriteLine(res);
}

//подсчёт колличества чётных чисел в массиве
int CountEven(int[] arr)
{
    int res=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        res++;
    }
    return res;
}