Console.Write("Input N nunmber: ");

int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
OutputNumbers(number, count);

void OutputNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        OutputNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}