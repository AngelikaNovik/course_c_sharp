// принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Write a nambers: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Write b nambers: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Write c nambers: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if(max<b) max = b;
if(max<c) max = c;

Console.Write("max= ");
Console.Write(max);