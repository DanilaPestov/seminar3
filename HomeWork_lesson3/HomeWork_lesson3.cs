Console.Clear();

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Для проверки, является ли число полидромом,");
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
int a = number;
int b = 0;
while (number > 0)
{
   int c = number % 10;
    b = b * 10 + c;
    number = number / 10;
}
if (b == a)
{
    Console.WriteLine("Это число является полидром.");
}
else
{
   Console.WriteLine("Это число НЕ ЯВЛЯЕТСЯ ПОЛИДРОМОМ.");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("У нас заданы две точки в 3D пространстве:");
int x1 = new Random().Next(-200, 200);
int y1 = new Random().Next(-200, 200);
int z1 = new Random().Next(-200, 200);
int x2 = new Random().Next(-200, 200);
int y2 = new Random().Next(-200, 200);
int z2 = new Random().Next(-200, 200);
Console.WriteLine($"A = ({x1},{y1},{z1}); B = ({x2},{y2},{z2})");

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между этими точками: {length}");

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("До какого числа нужна таблица кубов?");
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
Console.WriteLine($"Таблица кубов до {N}: ");
while (i < N)
{
    Console.Write($"{(int)Math.Pow(i, 3)}, ");
    i++;
}
Console.WriteLine($"{(int)Math.Pow(i, 3)}.");