string Method4(int count, string text) // что то принимают и что то возвращают
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return  result;
}
string res = Method4(5, "Сэлэм ");
Console.WriteLine(res);

