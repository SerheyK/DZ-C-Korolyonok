// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int numb1 = int.Parse(str);
Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int numb2 = int.Parse(str);
if (numb1>numb2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
Console.WriteLine("Второе число больше первого");
}