/*Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
Math.Pow использовать нельзя

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double f(double A, double B)
{
    double result = 1;
    for (double i = 0; i < B; i++)
    {
         result = result*A;
    }
    return result;
}
double re = f(2, 4);
Console.WriteLine(re);
