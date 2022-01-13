// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

Console.Title = "yasirsharp article_project back-end";
Console.WriteLine("Hello, World!");


UserManager userManager = new UserManager(new EfUserDal());

var users = userManager.GetAll();
if (users.Success)
{
    Console.WriteLine($"{users.Data.Count} kullanıcı bulundu. \nKullanıcılar: ");
    foreach (var user in users.Data)
    {
        Console.WriteLine($"{user.Id}     |  {user.UserName}#{user.UserCode} ({user.UserFirstName} {user.UserLastName})\n");
    }
}

void addTestUser()
{
    //User user = new User { 
    //    UserName = "deneme", 
    //    UserFirstName = "DenemeIsim", 
    //    UserLastName = "DenemeSoyIsim", 
    //    Email = "deneme.deneme@yasirsharp.com", 
    //    UserCode = 12345 ,
    //    Password = "deneme123",
    //};
    //userManager.Add(user);
}