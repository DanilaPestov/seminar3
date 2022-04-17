int x1 = 3;
int y1 = 4;
int x2 = 5;
int y2 = 2;
Console.WriteLine($"x1={x1}, y1={y1}, x2={x2}, y2={y2}");

int length = (int)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(length);