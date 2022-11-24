Console.Clear();
Console.WriteLine("Введите положительное число ");

string s = Console.ReadLine();
int num = Convert.ToInt32(s);

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}

else
{
    int des = num /100 % 10;
    Console.Write("третья цифра ->  ");
    Console.Write(des);
}