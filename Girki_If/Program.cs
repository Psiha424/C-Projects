int a = 2;
int b = 3;
int c = 8;
int d = 5;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);