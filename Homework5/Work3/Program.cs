int[] array = new int[4];
Random rand = new Random();
for (int i=0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}
System.Console.WriteLine(string.Join(", ", array));