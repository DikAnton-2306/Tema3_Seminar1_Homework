// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write ("Напишите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Напишите число B: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше. Число {numberB} меньше");
}
else
{
    Console.WriteLine($"Число {numberA} меньше. Число {numberB} больше");
}