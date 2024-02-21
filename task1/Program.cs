// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


int PrintNumbers(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{n}, ");
        if (m == n)
        {
            return (n);
        }

        return PrintNumbers(m, n + 1);
    }
    Console.Write($"{m}, ");
    if (m == n)
    {
        return (m);
    }
    return PrintNumbers(m + 1, n);
}
Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);
PrintNumbers(m, n);
