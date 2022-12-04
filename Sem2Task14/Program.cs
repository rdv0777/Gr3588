int numA =int.Parse(Console.ReadLine()??"0");

int result1 = numA%7;
int result2 = numA%23;

if ((result1==0)&&(result2==0))
{
    Console.WriteLine("Да");    
}

else
{
    Console.WriteLine("Нет" );
}
