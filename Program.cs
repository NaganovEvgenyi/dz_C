// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.WriteLine($"{num1} большее, {num2} меньшее");
}
else
{
    Console.WriteLine($"{num2} большее, {num1} меньшее");
 }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:");
int num3 = int.Parse(Console.ReadLine()!);
if (num1 > num2 & num1 > num3)
{
    Console.WriteLine($"max = {num1}");
}
else if (num2 > num3 & num2 > num1)
{
    Console.WriteLine($"max = {num2}");
}
else
{
    Console.WriteLine($"max = {num3}");
}
*/ 

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число:");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 % 2 == 0)
{
    Console.WriteLine($"Число {num1} является четным");
}
else
{
    Console.WriteLine("Число является не четным");
}