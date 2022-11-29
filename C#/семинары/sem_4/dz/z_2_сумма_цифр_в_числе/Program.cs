/* Задача 27: Напишите метод, который принимает на вход число
 и выдаёт сумму цифр в числе.

 9012 -> 12*/

int sum (int array)
{   int newArray = array;
    int summa = 0;
       while (newArray >= 1)
    {
        summa = summa + newArray%10;
        newArray = newArray/10;
    } 
     return  summa;
}
int result = sum(9012);
Console.WriteLine(result);
