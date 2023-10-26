int ImputInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minValue, maxValue + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }    
}

int rows = ImputInteger("Введите кол-во строк: ");
int columns = ImputInteger("Введите кол-во столбцов: ");
int minValue = ImputInteger("Введите мин. значение: ");
int maxValue = ImputInteger("Введите макс. значение: ");
int[,] arr = Create2DArray(rows, columns);
FillArray(arr, minValue, maxValue);
Print2DArray(arr);