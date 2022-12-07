// Задачи на сегодня


//Задача 1: Задайте массив из 12 элементов, 
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

// сумма положительных элементов

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

// сумма отрицательных элементов

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

// клиентскии код
int[] col = CreateArray(12);
Console.WriteLine(PrintGood(col));
Fill(col, -9, 9);
Console.WriteLine(PrintGood(col));
int pos = SumPositive(col);
Console.WriteLine($">0 {pos}");
int neg = SumNegative(col);
Console.WriteLine($"<0 {neg}");

// разница между min и max
double MaxMin(double[] mass2)
{
    double max = mass2[0];
    double min = mass2[0];
    
    int lens = mass2.Length;
    for (int i = 1; i < lens-1; i++)
    {
        
        if(mass2[i]>max) max= mass2[i];
        if(mass2[i]<min) min= mass2[i];
    }
    double raz = max-min;
    return raz;
}

// сумма элементов на нечетных индексах
int Sum_nech_ind(int[] mass2)
{
    int result = 0;
    int lens = mass2.Length;
    for (int i = 0; i < lens; i++)
    {
        if(i%2!=0) result = result + mass2[i];
        
    }

    return result;
}

// нахождение факториала
double Factorial(int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(3));
for (int i = 1; i < 50 ; i++)
{
    Console.WriteLine($"{i}!= {Factorial(i)}");
}

// фибоначчи
double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i<50; i++)
{
 Console.WriteLine($"f {i}: {Fibonacci(i)}");
}

// создает пустой двухмерный массив
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
        {
             Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();   
    }
}   

// заполняет 2мерный массив случайными числами
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10); //[1, 10)
        } 
    
    }
}
// клиентскии код создания и заполнения двумерных массивов
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

// красивый вывод одлномерного массива
int[] koeff = GetKoeff(tr, 6);
System.Console.WriteLine(String.Join(' ', koeff));

//сортировка одномерного массива min max вар 1
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1 ; i++)
    {
       int minPosition = i;

       for (int j = i+1; j < array.Length; j++)
       {
           if (array[j] < array [minPosition]) minPosition = j;
       }
       
        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;
    }

}
// сортировка одномерного массива min max вар 2
void SelectionSort(int[] matr)
{
    for (int i = 0; i < matr.Length-1 ; i++)
    {
       for (int j = i+1; j < matr.Length; j++)
       {
           if (matr[j] < matr [i])
           {    
                int temporary = matr[i];
                matr[i] = matr [j];
                matr [j] = temporary;
            }
        }
    }

}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

//выдаёт номер строки с наименьшей суммой элементов в двухмерном массиве
void MinStroka(int[,]matr)
{
    int summinstr = 0;
    for (int i = 0; i <  matr.GetLength(1); i++)
    {
        summinstr = summinstr + matr[0,i];
    }


    int sumstr =0; 
    int strminsum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++) sumstr = sumstr + matr[i,j];
        
        if(sumstr < summinstr)
        {
            summinstr = sumstr;
            strminsum = i;
        }
        sumstr = 0;   
        
    }
    Console.WriteLine($"строка {strminsum+1} - с минимальной суммой элементов");
}





// Задача 2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.



// Задача 3: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.



// Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]. 




// Задача 5: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д.Результат запишите в новом массиве.
// * Для нечетного количество центральный элемент возводится в квадрат