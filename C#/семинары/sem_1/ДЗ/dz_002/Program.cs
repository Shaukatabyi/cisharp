int a = 2;
int b = 9;
int c = 18;

int max = a;

if(b>max)
{
    max = b;
}
if(c>max)
{
    max = c;
}
Console.Write(a);
Console.Write(", ");
Console.Write(b);
Console.Write(", ");
Console.Write(c);
Console.Write(" -> ");
Console.Write(max);
