Console.Write ("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == " миша") // Без пробела в кавычках не срабатывает условие 
{
    Console.WriteLine("Ура, это же МИША!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
