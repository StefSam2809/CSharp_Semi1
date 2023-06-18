System.Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int numbera = number / 10;
int numberb = numbera % 10;
 
System.Console.WriteLine(numberb);