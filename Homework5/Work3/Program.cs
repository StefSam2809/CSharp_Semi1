double[] array = new double[4];
Random rand = new Random();
for (int i=0; i < array.Length; i++)
{
    array[i] = Math.Round(rand.NextDouble()*100, 2);
}
double max = array[0];
double min = array[0];
for (int i=0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}
for (int i=0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}
double number = max - min;
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(number);