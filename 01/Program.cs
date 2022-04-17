int x, y;
x = new Random().Next(-100, 330);
y = new Random().Next(-164, 304);
Console.WriteLine($"x={x}, y={y}");
if (x == 0 | y == 0)
{
    Console.WriteLine("не принадлежит конкретной четверти");
}
if (x > 0 & y > 0)
{
    Console.WriteLine("1 плоскость");
}
if (x > 0 & y < 0)
{
    Console.WriteLine("2 плоскость");
}
if (x < 0 & y < 0)
{
    Console.WriteLine("3 плоскость");
}
if (x < 0 & y > 0)
{
    Console.WriteLine("4 плоскость");
}