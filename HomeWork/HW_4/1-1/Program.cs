﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("переменная A");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("переменная B");
int b = Convert.ToInt32(Console.ReadLine());

int Step(int a, int b);
{
    int result = 1;
    for (int i = 1; i <= b; i++) ;
    {
        result = result * a;
    }

    return result;
}
Console.WriteLine("Step ");
