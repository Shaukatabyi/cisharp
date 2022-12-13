// По двум заданным числам проверять является ли первое квадратом второго


double numA = 81;
double numB = 2;

if(numA / numB == numB) Console.WriteLine($"{numA} является кватратом {numB}");

else 
    if(numB/ numA == numA) Console.WriteLine($"{numB} является кватратом {numA}");
    else Console.WriteLine("ни одно число не является кватратом другого ");

