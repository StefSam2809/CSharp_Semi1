int[] array = new int[4];
int x = 0;
Random rand = new Random();
for (int i=0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    if (array[i]%2 == 0)
    {
        x++;
    }
}
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(x);