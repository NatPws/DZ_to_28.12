// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
 int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.Write(" ]");
    System.Console.WriteLine();
} 



/* 
void PrintTurnedArra(int[] arrayForPrint2)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayForPrint2.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.Write(" ]");
    System.Console.WriteLine(); 

 void PrintTurnedArray(int array[i], int size)
{
    int currentDigit = array[i] % 10;
    if (array[i] > 0) return;
    {
        array[i] /= 10;
        Console.Write(currentDigit + ",");
    }

} 
}
 */
int[] myArray = GenerateArray(5, 0, 9);
PrintArray(myArray);
/* System.Console.WriteLine(Reverse); */
 





















/* Console.Write("Задайте произвольный массив из 4 чисел: ");
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
*/