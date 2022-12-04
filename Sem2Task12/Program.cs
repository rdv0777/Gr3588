int numA =int.Parse(Console.ReadLine()??"0");
int numB =int.Parse(Console.ReadLine()??"0");

int result = numA%numB;

if (result==0)
{
    Console.WriteLine("второе число делится на первое без остатка");    
}

else
{
    Console.WriteLine("второе число не кратно первому" + result);
}


