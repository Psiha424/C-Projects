string DecimalToBinary(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /=2;
    }
    return result;
}

System.Console.WriteLine("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DecimalToBinary(num));