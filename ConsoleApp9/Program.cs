double[] array = new Double[20];
Random rnd = new Random();

for (int i = 0; i <= 19; i++)
{
    array[i] = Math.Round(rnd.NextDouble()*100,2);
}
string str = string.Join("; ",array);
Console.WriteLine(str);
double min = array.Min();
double max = array.Max();
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max - min);