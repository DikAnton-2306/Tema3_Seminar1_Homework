// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write ("Напишите число A: ");
int numberA = int.Parse(Console.ReadLine ());
Console.Write ("Напишите число B: ");
int numberB = int.Parse(Console.ReadLine ());
Console.Write ("Напишите число C: ");
int numberC = int.Parse(Console.ReadLine ());
int max = numberA;
if (max < numberB) max = numberB;
if (max < numberC) max = numberC;
Console.WriteLine($"Максимальное число из введённых {max}");