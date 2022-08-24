Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("max = ");
Console.Write(max);