// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 //с рекурсией
int SumNat1(int m, int n)
{  
    if(m<0 || n<0) return 0;
    else
    { 
        if(m<=n)
        {
            if(n==m) return m;
            else return  m+SumNat1(m+1, n);
        }
        else return m+SumNat1(m-1, n);
    }
    
}  

int num3 = -4;
int num4 =8;
System.Console.WriteLine(SumNat(num3, num4)); 

//без рекурсии
int SumNat(int m, int n)
{
    if (m<0 || n<0) return 0;

    else
    { 
        if(m<=n)
        {
            int result = 0;
            for (int i = m; i <= n; i++) 
                {
                    result += i;
                }
            return result; 
        }
        else 
        {
            int result = n;
            for (int i = m; i > n; i--) 
                {
                    result += i;
                }
            return result;
        }
    }
}

int num1 = 8;
int num2 =4;
System.Console.WriteLine(SumNat(num1, num2)); 
