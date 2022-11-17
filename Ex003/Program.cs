// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
string str = Console.ReadLine();
int first = int.Parse(str);
int a = first % 2;
if (a == 0)
{
    Console.WriteLine("Ваше число является четным");
}
else
{
    Console.WriteLine("Ваше число является нечетным");
}