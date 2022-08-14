using System;
int n = Int32.Parse(Console.ReadLine() ?? string.Empty);
if ((n < 10000) | (n > 99999))
{
    Console.WriteLine("число не пятизначное");
}
else
{

    if (n % 100 == n / 10000 + n /1000 % 10 * 10)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}