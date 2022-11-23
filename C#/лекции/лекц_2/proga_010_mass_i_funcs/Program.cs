int[] array = {17, 22, 13, 26, 53, 26, 17, 18};
int n = array.Length;
int find = 26;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}