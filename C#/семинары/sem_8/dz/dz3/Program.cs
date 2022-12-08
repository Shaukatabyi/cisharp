/*Задача 60.
 ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/ 

// Функция вывода индекса элементов 3D массива
void Print3D(int[, ,] mass3d)
{
    for (int i = 0; i < mass3d.GetLength(0); i++)
    {
        for (int j = 0; j < mass3d.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < mass3d.GetLength(2); k++)
            {
                System.Console.Write($"{mass3d[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}
// Функция заполнения 3D массива не повторяющимеся числами
 void Zapol3D(int[, ,] massiv3d)
 {
    int tsifra = 10;
    for (int i = 0; i < massiv3d.GetLength(0); i++)
    {
        for (int j = 0; j < massiv3d.GetLength(1); j++)
        {
            for (int k = 0; k < massiv3d.GetLength(2); k++)
            {
                massiv3d[i,j,k] = tsifra;
                tsifra += 1;
            }
        }
    }
 }

int[,,] array3D = new int[2, 2, 2];
Zapol3D(array3D);
System.Console.WriteLine(array3D);
Print3D(array3D);
System.Console.WriteLine(array3D);
