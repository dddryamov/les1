Console.WriteLine("ВВесдите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура Это МАША");
}
else
{
    Console.WriteLine("Привет " );
    Console.Write(username);
}