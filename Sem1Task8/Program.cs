// Считываем данные с консоли
string? numLineN  = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (numLineN != null)
{
// Парсим введённое число
int numN = int.Parse(numLineN);
// Вводим переменные
int firstNumber = 2;
string results = string.Empty;
// Запускаем цикл
while (firstNumber<numN)
{
   results = results + firstNumber + "," ;
   firstNumber = firstNumber + 2 ;
}
// Проверяем на чётность число N
if (numN%2==0)
{
    results=results+numN;

    // Выводим данные в консоль
    Console.WriteLine(results);   
}
else
{

    // Выводим данные в консоль
    Console.WriteLine(results);   
}
}
