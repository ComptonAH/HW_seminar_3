Console.Write("Enter a value of X for the first point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value of Y for the first point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value of Z for the first point: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value of X for the second point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value of Y for the second point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value of Z for the second point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.Write(result);