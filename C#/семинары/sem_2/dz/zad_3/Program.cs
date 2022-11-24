Console.Clear();
Console.WriteLine("Введите цифру дня недели ");

string s = Console.ReadLine();
int num = Convert.ToInt32(s);

if (num < 1) 
{
    Console.WriteLine("такого дня недели нет");
}
else
{
   if (num > 7) 
    {
    Console.WriteLine("такого дня недели не существует");
    }
    else
    {
       if (num == 6) 
        {
        Console.WriteLine("да");
        } 
        else
        {
            if (num == 7) 
            {
                 Console.WriteLine("да");
            }

            else
            {
                 Console.Write("нет");
            }
        }
    }
}
