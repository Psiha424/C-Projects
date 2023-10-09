int Prompt(string message)
{
    System.Console.Write(message);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.Write($"Сумма цифр равна {number} = {SumAllDigit(number)}");
