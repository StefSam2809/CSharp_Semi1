int[] array = new int[4];
int x = 0;
Random rand = new Random();
for (int i=0; i < array.Length; i++)
{
    array[i] = rand.Next(-99, 100);
    if (i%2 == 1)
    {
        x = x + array[i];
    }
}
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(x);