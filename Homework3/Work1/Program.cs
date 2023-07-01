System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string? str = a.ToString();

if(a > 10000 && a < 99999)
{
    if(str[0] == str[4] && str[1] == str[3])
    {
         System.Console.WriteLine("Число палиндром"); 
    } else System.Console.WriteLine("Число не палиндром");
    
} else System.Console.WriteLine("Некорректный ввод");