/* Задача 64: Задайте значения M и N.
 Напишите программу, которая выведет все натуральные числа в промежутке от M до N.*/

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
