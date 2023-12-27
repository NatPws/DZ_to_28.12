// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

string firstComand = "Введите значение m: ";
System.Console.Write(firstComand);
int firstNumber = Convert.ToInt32(Console.ReadLine());
string secondComand = "Введите значение n: ";
System.Console.Write(secondComand);
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));    
}

System.Console.WriteLine($"Значение по фукнкции Аккермана ({firstNumber},{secondNumber}) = {Akkerman(firstNumber, secondNumber)}");