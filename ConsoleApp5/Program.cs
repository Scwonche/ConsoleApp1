int n = int.Parse(Console.ReadLine());
int sum = 0;
if (n < 0)
{
    n = Math.Abs(n);
}
while (n > 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum);