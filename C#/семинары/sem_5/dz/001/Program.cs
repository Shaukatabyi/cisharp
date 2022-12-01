// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int SummaChetn(int[] massiv1)
{
    int le = massiv1.Length;
    int res = 0;
    for (int i = 0; i < le; i++)
    {
        if(massiv1[i] % 2 == 0) res ++;
        
    }
    return res;
   
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

//клиентский код

int[] itog = SozdaetMas(new Random().Next(0, 15));
Console.WriteLine(PechatMas(itog));

ZapolnMas(itog, 100, 999);
Console.WriteLine(PechatMas(itog));

int chetn = SummaChetn(itog);
Console.WriteLine($"Количество чётных чисел = {chetn}");
