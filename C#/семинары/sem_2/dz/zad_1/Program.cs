Console.Clear();
Console.WriteLine("Введите трёхзначное число ");

string s = Console.ReadLine();
int num = Convert.ToInt32(s);

if (num > 999)
{
    Console.WriteLine("error");
}
if (num < 100)
{
    Console.WriteLine("error");
}


else
{
    int des = num / 10 % 10;
    Console.Write("вторая цифра ->  ");
    Console.Write(des);
}