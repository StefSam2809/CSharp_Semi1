Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= num)
{
    System.Console.WriteLine(Math.Pow(i , 3));
    i++;
}
