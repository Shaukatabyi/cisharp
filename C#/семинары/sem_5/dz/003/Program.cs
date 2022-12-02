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

double Max_Min(double[] mass2)
{
     double raz = Math.Max(mass2) - Math.Min (mass2);
//     //double min = 0;
//     int lens = mass2.Length;
//     for (int i = 0; i < lens; i++)
//     {
//         if(mass2[i]>mass2[i+1]) max= mass2[i];
        
//     }

    return raz;
}



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

double rr = Max_Min(itog);
Console.WriteLine(rr);