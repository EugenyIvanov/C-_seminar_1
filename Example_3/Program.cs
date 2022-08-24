Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    Console.Write("Четное число");
}
else
{
    Console.Write("Нечетное число");
}