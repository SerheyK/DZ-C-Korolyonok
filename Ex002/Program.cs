// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int numb1 = int.Parse(str);
Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int numb2 = int.Parse(str);
Console.WriteLine("Введите третье число");
str = Console.ReadLine();
int numb3 = int.Parse(str);
if (numb1>numb2 && numb1>numb3)
{
    Console.WriteLine("Максимальное число из заданных"  +  numb1);
}
if (numb3>numb1 && numb3>numb2);
{
    Console.WriteLine("Максимальное число из заданных "  +  numb3);
}
if (numb2>numb1 && numb2>numb3)
{
    Console.WriteLine("Максимальное число из заданных "  +  numb2);
}