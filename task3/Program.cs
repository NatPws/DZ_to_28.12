// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.Write("Задайте произвольный массив из 4 чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
// поменять через GENERATE ARRAY
int[] array = new int[4];
int i = 0;

void Array(int number)
{
if (array[i] < array.Length) 
    return;
     if (i == 0)
    {    array[i] = number % 10;
         number /= 10;
    // тут не совсем рекурсия, надо подумать, загуглить, исправить
    }
    Console.Write(array[i]);
   

}


Console.Write(array[i]);