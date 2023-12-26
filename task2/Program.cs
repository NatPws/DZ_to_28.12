// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 3;
int n = 5;


void Akkerman(n, m)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n = 0)) return Akkerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akkerman(m - 1, Akkerman(m, n - 1));
}
 
Console.WriteLine(Akkerman); 

 
Console.ReadKey();