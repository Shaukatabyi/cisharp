/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 08*/

int[] SozdaetMas (int cifra)
{
    return new int[cifra];
};
void ZapolnMas (int[] massiv, int min, int max)
{
    int dlina = massiv.Length;
    for (int i = 0; i < dlina; i++)
    {
        massiv[i] = new Random().Next(min, max+1);
    }
}
// сумма элементов на нечетных индексах
int Sum_nech_ind(int[] mass2)
{
    int result = 0;
    int lens = mass2.Length;
    for (int i = 0; i < lens; i++)
    {
        if(i%2!=0) result = result + mass2[i];
        
    }

    return result;
}

string PechatMas(int[] nomer)
{
    int len = nomer.Length;
    string result = " ";
    for (int i = 0; i < len; i++)
    {
        result = result +  ($"{nomer[i],4}");
    }
    return result;
}
// клиентский код

int[] itog = SozdaetMas(new Random().Next(5, 15));
Console.WriteLine(PechatMas(itog));

ZapolnMas(itog, 1, 10);
Console.WriteLine(PechatMas(itog));
int sum = Sum_nech_ind(itog);


Console.WriteLine($"сумма элементов с нечетным индексом = {sum}");