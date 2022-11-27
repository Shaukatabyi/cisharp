// ВИД 1

void Method1() // ничего не принимает и ничего не возвращает
{
    Console.WriteLine("Автор ЗШГ");
}
// Method1();



// ВИД 1

void Method2(string msg)  // принимает аргументы ,ничего не возвращает
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");



// // ВИД 2.1 именной аргумент
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); // неименованные аргументы идут по порядку
// Method21(count: 4, msg:"Текст"); // именованные аргументы, можно менять местами


// ВИД 3

int Method3() // ничего не принимает, но что то возвращает
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);




// ВИД 4 

string Method4(int count, string text) // что то принимают и что то возвращают
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return  result;
}
string res = Method4(5, "Сэлэм ");
Console.WriteLine(res);