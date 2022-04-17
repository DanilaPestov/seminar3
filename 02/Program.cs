Console.WriteLine("Введите номер четверти");
int num;
num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("x = от 0 до бесконечности, у = от 0 до бесконечности");
}
else if (num == 2)
{
    Console.WriteLine("x = от 0 до бесконечности, у = от 0 до - бесконечности");
}
else if (num == 3) 
{
    Console.WriteLine("x = от - бесконечности до 0, у = от - бесконечности до 0");
}
else if (num == 4) 
{
    Console.WriteLine("x = от - бесконечности до 0, у = от 0 до бесконечности");
}
else 
{
    Console.WriteLine("четверть не существует");
}