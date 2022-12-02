// Задача 38:
//  Задайте массив вещественных чисел.
//   Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] SozdaetMas (int cifra)
{
    return new double[cifra];
};

void ZapolnMas (double[] massiv, int min, int max)
{
    int dlina = massiv.Length;
    for (int i = 0; i < dlina; i++)
    {
        double d  = (Random.Shared.Next(100,999))/10.0;
        massiv[i] =d;
    }
}

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

//  int[] a = { 3, 4, 21, 1 };
// int max = a[0];
// for (int i = 0; i < a.Length; i++) if (a[i] > max) max = a[i];
// System.Console.WriteLine(max);


string PechatMas(double[] nomer)
{
    int len = nomer.Length;
    string result = " ";
    for (int i = 0; i < len; i++)
    {
        result = result +  ($"{nomer[i],6}");
    }
    return result;
}

// клиентский код

double[] itog = SozdaetMas(new Random().Next(5, 15));
//Console.WriteLine(PechatMas(itog));

ZapolnMas(itog, 1, 10);
Console.WriteLine(PechatMas(itog));
Console.Write("Разница между max и min = ");
double rr = MaxMin(itog);
Console.WriteLine(rr);