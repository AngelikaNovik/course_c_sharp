﻿// на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"палиндром.");
  }
  else Console.WriteLine($"не палиндром.");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
