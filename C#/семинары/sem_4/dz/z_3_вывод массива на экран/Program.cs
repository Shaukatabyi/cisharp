
/*Задача 29:
 Напишите методы, который задаёт массив из 8 элементов
 и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/


int[] array = new int[8]{ 1, 2, 5, 0, 19, 6, 0, 33 };

string PrintGood(int[] array)
{
    int size = array.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result = result + ($"{array[i]} ");
        i++;
    }
    return result + "]";
}
Console.WriteLine(PrintGood(array));

