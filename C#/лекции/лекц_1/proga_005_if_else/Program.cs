Console.Write("Как Вас зовут? ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привеет, это же Маша!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}    