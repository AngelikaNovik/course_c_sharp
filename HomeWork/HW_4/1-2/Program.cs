//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("введите число ");
int i = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (i > 0) ;
{
    int n = i % 10;
    i = i / 10;
    result = result + n;
}
Console.WriteLine("Сумма цифр: ");