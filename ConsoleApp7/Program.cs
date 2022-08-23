int[] array = new int[8];
Random rnd = new Random();
int k = 0;
for (int i = 0; i <= 7; i++)
{
    array[i] = rnd.Next(100,999);
    if (array[i] % 2 == 0)
    {
        k += 1;
    }
}
string str = string.Join(" ",array);
Console.WriteLine(str);
Console.WriteLine(k);