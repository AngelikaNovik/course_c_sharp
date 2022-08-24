// Задайте значения M и N. 
//Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.

int n = InputNum("Введите n: ");
int count = 2;
PrintNum(n, count);
Console.Write(1);

void PrintNum(int n, int count)
{
    if (count > n) return;
    PrintNum(n, count + 1);
    Console.Write(count + ",");
}
int InputNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
