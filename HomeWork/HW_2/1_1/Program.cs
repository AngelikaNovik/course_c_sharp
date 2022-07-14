// на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine((a/10)%10);