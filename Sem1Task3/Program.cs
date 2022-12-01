// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLine!=null)
{
    // Создаём массив с днями недели
    string[] dayOfWerek = new string[7];
    dayOfWerek[0] = "понедельник";
    dayOfWerek[1] = "вторник";
    dayOfWerek[2] = "среда";
    dayOfWerek[3] = "четверг";
    dayOfWerek[4] = "пятница";
    dayOfWerek[5] = "суббота";
    dayOfWerek[6] = "воскресение";

    // Парсим введённое число
    int inputNumber = int.Parse(inputLine);

    // Находим название дня недели по введённому номеру
    string outDayOfWeek = dayOfWerek[inputNumber-1];

    // Выводим данные в консоль
    Console.WriteLine(outDayOfWeek);


}


