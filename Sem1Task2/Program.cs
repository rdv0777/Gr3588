// Считываем данные с консоли
string? numLineA = Console.ReadLine();
string? numLineB = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (numLineA != null && numLineB != null)
{
    // Парсим введённое число
int numA = int.Parse(numLineA);
int numB = int.Parse(numLineB);
// Сравниваем значения
if (numA>numB)
{
    // Выводим данные в консоль
 Console.WriteLine("Первое число больше второго");   
}
else
{
    Console.WriteLine("Первое число меньше второго"); 
}


}
