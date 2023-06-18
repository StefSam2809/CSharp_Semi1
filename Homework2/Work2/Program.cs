System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)
{
    System.Console.WriteLine("Третьей цифры нет");
}
int x = number;
int z = 1;
while (x > 0)
{
    x = x / 10;
    z = z * 10;
} z = z / 1000;

int numbera = number / z;
int numberb = numbera % 10;

System.Console.WriteLine(numberb);