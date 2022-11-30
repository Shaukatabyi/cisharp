// Задачи на сегодня


// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// метод, который создаёт массив
int[] CreateArray(int count)
{
  return new int[count];
}

// заполняет массив
void Fill(int[] array, int min, int max)
{
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    array[i] = Random.Shared.Next(min, max + 1);
    //array[i] = new Random().Next(min, max);
  }
}

// печать массив
string PrintGood(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{numbers[i],3} ");
    i++;
  }
  return result + "]";
}

int SumPositive(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] > 0) result += numbers[i];
  }
  return result;
}

int SumNegative(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] < 0) result += numbers[i];
  }
  return result;
}

// 
int[] col = CreateArray(12);
Console.WriteLine(PrintGood(col));
Fill(col, -9, 9);
Console.WriteLine(PrintGood(col));
int pos = SumPositive(col);
Console.WriteLine($">0 {pos}");
int neg = SumNegative(col);
Console.WriteLine($"<0 {neg}");

// Задача 2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.



// Задача 3: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.



// Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]. 




// Задача 5: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
// * Для нечетного количество центральный элемент возводится в квадрат