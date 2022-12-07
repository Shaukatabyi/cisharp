/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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


int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinStroka(matrix);

