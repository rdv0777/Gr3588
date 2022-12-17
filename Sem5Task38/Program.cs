


double[] array = GenArray(12,1,99);
Print1DArr(array);
 Console.WriteLine();
double min = double.MaxValue;
double max = double.MinValue;
MinMax(array);
double result = max-min;
PrintData(result);

//создаём массив заполненный случайными вещественными числами
double[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd =new Random(); 
    double[] arr = new double[len]; 
    for (int i = 0; i < arr.Length; i++)  
    {                                             
         arr[i] = rnd.Next(minValue, maxValue +1) + rnd.NextDouble();
        
    }
    return arr; 
}

// выводим сгенерированный массив
void Print1DArr (double[] arr)
{
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + "  "  );
    }
    Console.WriteLine(arr[arr.Length-1]);
}

//выводим результат
void PrintData(double result)
{
    Console.WriteLine(result);
}

//находим максимальное и минимальное  число  в  массиве
void MinMax(double[] arr)
{
    for(int i =0;i < arr.Length;i++)
    {
       if(arr[i]>max) max = arr[i];
       if(arr[i]<min) min = arr[i];  
    }
    
}


