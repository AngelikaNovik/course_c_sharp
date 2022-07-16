// выводит случайное трёхзначное число и удаляет вторую цифру этого числа

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"{a/100}{a%10}");
