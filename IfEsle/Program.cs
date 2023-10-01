Console.Write("Введите Имя Пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ксюша")
{
    Console.WriteLine("Ура Ура, это же КСЮША!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}    