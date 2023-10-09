int Prompt(string message)
{
    System.Console.Write(message);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
};

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель меньше 0");
        return false;
    }
    return true;
};

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите степень: ");
if (ValidateExponent(exponent))
{
    System.Console.Write($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}