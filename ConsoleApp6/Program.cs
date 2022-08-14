int[] array = new int[8];
Random rnd = new Random();
for (var i = 0; i <= 7; i++)
{
    array[i] = rnd.Next(100);
}
var str = string.Join(" ",array);
Console.WriteLine(str);