Console.WriteLine("Можете вводить");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}
else
{

    if (numberA > numberB)
    {
        Console.Write(numberA);
        Console.Write(" - Данное число больше, соответственно второе меньше");
    }
    else
    {
        Console.Write(numberB);
        Console.Write(" - Данное число больше, соответственно второе меньше");
    }
}