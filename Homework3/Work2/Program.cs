int[] aCoor = new int[3];
int[] bCoor = new int[3];

Console.WriteLine("Введите первую координату");

Console.WriteLine("Введите x первой координаты");
aCoor[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой координаты");
aCoor[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой координаты");
aCoor[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату");

Console.WriteLine("Введите x второй координаты");
bCoor[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй координаты");
bCoor[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй координаты");
bCoor[2] = Convert.ToInt32(Console.ReadLine());

double resalt = Math.Sqrt(Math.Pow((bCoor[0] - aCoor[0]), 2) + Math.Pow((bCoor[1] - aCoor[1]), 2) + Math.Pow((bCoor[2] - aCoor[2]), 2));

System.Console.WriteLine(Math.Round(resalt, 2));


