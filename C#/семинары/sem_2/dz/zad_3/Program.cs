Console.Clear();
Console.WriteLine("Введите цифру дня недели ");

string s = Console.ReadLine();
int num = Convert.ToInt32(s);

if (num < 1) 
{
    Console.WriteLine("такого дня недели нет");
}
if (num > 7) 
{
    Console.WriteLine("такого дня недели не существует");
}

if (num == 6) 
{
    Console.WriteLine("да");
}

if (num == 7) 
{
    Console.WriteLine("да");
}

else
{
    Console.Write("нет");
}