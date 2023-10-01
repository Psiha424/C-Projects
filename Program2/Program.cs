int a, b, c;

Console.Write("Введите первое число:");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
c = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
{
if (a > c)
{
    Console.Write("первое число - наибольшее. ");
}
else
{
    Console.Write("третье число - наибольшее. ");
}
}
else if (b > c)
    Console.Write("второе число - наибольшее. ");
else
    Console.Write("третье число - наибольшее. ");
