int[] array = new int[100];
Random rnd = new Random();
int s = 0;
for (int i = 0; i <= 99; i++)
{
    array[i] = rnd.Next(10,99);
    if (i % 2 == 0)
    {
        s += array[i];
    }
}
string str = string.Join(" ",array);
Console.WriteLine(str);
Console.WriteLine(s);