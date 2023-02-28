// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DBFirstApp;

using (HelloappContext db = new HelloappContext())
{
	var users = db.Users.ToList();
	Console.WriteLine("Список объектов");
	foreach (User user in users)
	{
		Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
	}
}