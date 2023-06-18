System.Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int x = Convert.ToInt32(number1);

if (x<number2)
{
    x = number2;
    if (x<number3)
    {
        x = number3;
    }
}

if (x<number3)
{
    x = number3;
}

Console.WriteLine( x );