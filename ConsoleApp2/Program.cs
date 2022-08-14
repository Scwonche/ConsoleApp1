using System;
string[] arr1= Console.ReadLine().Split();
 
double x1 = double.Parse(arr1[0]);
double y1 = double.Parse(arr1[1]);
double z1 = double.Parse(arr1[2]);

string[] arr2= Console.ReadLine()?.Split();
 
double x2 = double.Parse(arr2[0]);
double y2 = double.Parse(arr2[1]);
double z2 = double.Parse(arr2[2]);
double a = Math.Pow(x2 - x1, 2);
double b = Math.Pow(y2 - y1, 2);
double c = Math.Pow(z2 - z1, 2);
Console.WriteLine(Math.Round(Math.Sqrt(a+b+c),2));