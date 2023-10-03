void CheckMultiplicity(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2} -> кратно");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
    }
}

Console.Write("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());

CheckMultiplicity(n1, n2);