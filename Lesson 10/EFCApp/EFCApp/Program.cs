using EFCApp;
using EFCApp.Entities;

User user = new User()
{
    Name = "Valera",
    Surname = "Lappo"
};

Operations.Create(user);
User gotUser = Operations.Read(1);

Console.WriteLine($"Name: {gotUser.Name}, Surname: {gotUser.Surname}");
Console.ReadKey();

