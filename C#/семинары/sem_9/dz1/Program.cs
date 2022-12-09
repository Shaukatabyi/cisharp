/*Задача 64: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


//4=3+1;3=2+1; 2=1+1; 1=1; n=(n-1)+1;

// int Nat1(int n)
// {   
//     if(n<=0) return 0;
//     if(n==1) return 1;  
//     else return n-Nat1(n-1) ; 
    
    
// }
// int zx = 5;
// System.Console.WriteLine(Nat1(zx));


string Nat(int n)
{
string asd = String.Empty;
if (n < 1) return "не натуральное";
if(n==1) return " 1";
else asd += $" {n},{Nat(n-1)}";
return asd;
}

int number = 8;

Console.WriteLine(Nat(number));