Console.WriteLine("Введите число");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);
int count = 1;
while(count <= n)
{
if (count % 2 == 0)
{
Console.WriteLine(count);

}
count = count + 1;
}
