// Вариант 1
// создаём экземпляр класса рандомайзер
System.Random numberSintezator =new System.Random();

// Получаем новое случайное число
int number = numberSintezator.Next(10,100);


// Выводим данные в консоль
Console.WriteLine(number);


//Получаем первое и второе число по отдельности
int firstNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if (firstNumber>secondNumber)
{
    //выводим в консоль
    Console.WriteLine(firstNumber);
}
else
{
// Выводим данные в консоль
Console.WriteLine(secondNumber);
}
// Вариант 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);

// вариант 3

int[] indexAnsw = new int[90];

//выодим данные в консоль
Console.WriteLine(indexAnsw[number-10]);






