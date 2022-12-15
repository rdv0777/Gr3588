
int[] array = GenArray(10,-9,10);
Print1DArr (array);
int num = ReadData("Введите число");
int result = SearchElem(array, num);

if(result>=0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("Элемент не найден");
}

int[] GenArray(int len, int minValue, int maxValue)
{
   
        int[] arr = new int[len]; //Создали массив 
        for (int i = 0; i < arr.Length; i++)  //Мин макс значение
        {                                              //Проходим по массиву заполняем его 
            arr[i] = new Random().Next(minValue, maxValue +1);
        }
        return arr; //Выдаем результат
}
//Печатает одномерный массив
void Print1DArr (int[] arr)
{
    for (int i=0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1]);
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i]==elem)
        {
            res=i;
            break;
        }
        
    }
     return res;
}