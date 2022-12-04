
// создаём экземпляр класса рандомайзер
System.Random numberSintezator =new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(100,1000);
// Выводим данные в консоль
Console.WriteLine(number);




int resultNumber = (number/100) * 10 + number%10;
Console.WriteLine(resultNumber);
