void ShowNums(int n)
{
    if (n > 0)
    {
        ShowNums(n - 1);
        System.Console.Write(n + " ");

    }
}
ShowNums(10);