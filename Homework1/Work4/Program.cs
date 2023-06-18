System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int x = Convert.ToInt32(2);

while  (number >= x)
{
    if (x%2 == 0)
    {
        System.Console.WriteLine(x + " ");
    }
 x++;
}