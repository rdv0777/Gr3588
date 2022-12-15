
int[] array = GenArray(123,100,999);
Print1DArr(array);
 Console.WriteLine();
int result = SamOdd(array);
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
//подсчёт сумммы  не чётных чисел в массиве
int SamOdd(int[] arr)
{
    int res=0;
    int i=1;
    while (i < arr.Length)
    {
        res+=arr[i];
        i=i+2;
    }
    return res;
}
