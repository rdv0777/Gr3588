void Test(int i, int j)
{
    bool result = (i/j==j);

    if(result==true)Console.WriteLine("Число "+i+" является квадратом числа "+j);
    else Console.WriteLine("Число "+i+" не является квадратом числа "+j);
}
int num1 =int.Parse(Console.ReadLine()??"0");
int num2 =int.Parse(Console.ReadLine()??"0");
Test(num1,num2);
Test(num2,num1);

