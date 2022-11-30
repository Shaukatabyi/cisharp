/*Задача 29:
 Напишите методы, который задаёт массив из 8 элементов
 и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
// 1. метод, создающий массив с указанным количеством эл.

int[] func(int count)
{
    return new int[count];
}
int countElements = 8;
int[] arr = func(countElements);

Console.WriteLine(arr);


// 2. метод, заполняющий массив поэлементно *от пользователя

void Fill(int[] array)
{
  int size = array.Length;

  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber($"array[{index}]: ");
    index++;
  }
}


 //5.2 метод, печатающий массив 
string PrintGood(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result += ($"{numbers[i]} ");
        i++;
    }
    return result + "]";
}



Fill(arr);
PrintGood(arr);

Console.WriteLine(PrintGood(arr));
