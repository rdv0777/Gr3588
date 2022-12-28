
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int m = ReadData("Введите число M; ");
int n = ReadData("Введите число N; ");
Akkerman(m,n);
PrintResult(m,n);

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int m, int n )
{
    Console.Write(Akkerman (m,n)); 
}

// Метод функция Аккермана
int Akkerman(int m, int n)

{
    if (m == 0) return n+ 1;
    if (m != 0 && n == 0) return  Akkerman(m - 1, 1);
    if (m > 0 && n> 0) return  Akkerman(m - 1,  Akkerman(m, n- 1));
    return  Akkerman(m,n);
}