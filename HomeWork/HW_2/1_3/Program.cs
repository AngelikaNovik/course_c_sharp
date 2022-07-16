// выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

if (a > 99)
{
    Console.WriteLine(a%10);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

