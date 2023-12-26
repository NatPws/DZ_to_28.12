// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void numbers(int m, int n)
{
    if (m > n)
        return;
    if (m % 1 == 0)
    {
        Console.Write($"{m}, ");
    }
    numbers(m + 1, n);
}



numbers(m, n);