// Считываем данные с консоли
string? numLineA = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (numLineA != null)
{
    // Парсим введённое число
int numA = int.Parse(numLineA);
int numB=numA%2;

// Сравниваем значения
if (numB==0)
{
    // Выводим данные в консоль
    Console.WriteLine("Чётное");   
}
else
{
    Console.WriteLine("нечётное"); 
}


}
