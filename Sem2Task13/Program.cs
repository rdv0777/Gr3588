
// Считываем данные с консоли. Проверяем чтобы данные были не пустыми
int num =int.Parse(Console.ReadLine()??"0");

// Проверяем, чтобы число было трехзначным
if ( num>99)
{
    
Char[] digits = num.ToString().ToCharArray();

   // Выводим данные в консоль
      Console.WriteLine(digits[2] );
}    
else
{
     Console.WriteLine("Данное число не является трехзначным" );   
}