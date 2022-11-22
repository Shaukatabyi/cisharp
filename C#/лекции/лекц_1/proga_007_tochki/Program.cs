//Console.Clear();
//Console.SetCursorPosition(5, 1);
//Console.WriteLine("+");

int xa = 30, ya = 1,
    xb = 1, yb = 25,
    xc = 100, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("a");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("b");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("c");

int x = xa, y = xb;

int count =0;

while(count <50000)
{
    int what = new Random().Next(0, 3);// [0,3) 0 1 2
    if(what==0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    } 
    if(what==1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }
     if(what==2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine(".");
    count = count + 1;
}