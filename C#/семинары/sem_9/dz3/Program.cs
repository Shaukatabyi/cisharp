﻿/*Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Akkermana(int m, int n)
{
    if (m==0) return n+1;
     else
     {  if(m>0 && n==0) return Akkermana(m-1, 1);
        else return Akkermana(m-1,Akkermana(m, n-1));
     }  
}
int m =2;
int n = 3;
System.Console.WriteLine(Akkermana(m,n));

//взял в интернете формулу и просто подставил в метод, а объяснить как это работает не могу