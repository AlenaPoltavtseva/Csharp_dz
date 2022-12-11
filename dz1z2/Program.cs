Console.WriteLine("Вводите");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if ((b < c) & (c > max))
{
    max = c;
}
Console.WriteLine(max);