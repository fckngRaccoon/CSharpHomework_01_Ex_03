Console.Write ("Ведите число: ");
int number = Console.Read();

if (number == 0)
{
    Console.Write ("Ноль");
}
else if (number % 2 == 0)
{
    Console.Write ("Четное");
}
else
{
    Console.Write ("Нечетное");
}