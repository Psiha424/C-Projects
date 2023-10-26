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
    System.Console.WriteLine();
}



void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 <0 || row2 <0)
    {
        System.Console.WriteLine("Индекс не подходит");
        
    }
    else
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    
}

System.Console.Write("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input num of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input 1st row: ");
int row1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input 2nd row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
FillArray(myArray, minValue, maxValue);
Print2DArray(myArray);
ChangeRows(myArray, row1, row2);
Print2DArray(myArray);