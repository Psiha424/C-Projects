Console.WriteLine("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
    
for (int a = 1; a <= n; a++)
    if (a % 2 == 0)
        Console.WriteLine(a);