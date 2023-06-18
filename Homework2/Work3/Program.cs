System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number/8 > 0)
{
    System.Console.WriteLine("Некорректный ввод");
} else if (number / 5 > 0)  
{
    System.Console.WriteLine("Выходной день");
} else System.Console.WriteLine("Рабочий день");