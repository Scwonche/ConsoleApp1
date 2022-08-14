int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int p = 1;
for (int i = 1; i <= b; i++)
{
    p *= a;
}
Console.WriteLine(p);