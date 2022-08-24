Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int index = 1;
while (index <= x)
{
    if(index % 2 == 0)
    Console.WriteLine(index);
    index++;
}