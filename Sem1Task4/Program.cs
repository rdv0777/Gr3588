// Считываем данные с консоли
string? numLineA = Console.ReadLine();
string? numLineB = Console.ReadLine();
string? numLineC = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (numLineA != null && numLineB != null && numLineC != null)
{

    // Парсим введённое число
int num1 = int.Parse(numLineA);
int num2 = int.Parse(numLineB);
int num3 = int.Parse(numLineC);

// Сравниваем значения
if (num1>num2)
{
   if (num1>num3) 
   // Выводим данные в консоль
    {
     Console.WriteLine("max"+num1); 
    }
   
    else 

   // Выводим данные в консоль
    {
        Console.WriteLine("max"+num3); 
    }
}
else
{
    if (num2>num3)
   // Выводим данные в консоль
    {
        Console.WriteLine("max"+num2); 
    }
    else 

  // Выводим данные в консоль
    {
        Console.WriteLine("max"+num3); 
    }
}
}