﻿
using _01_Exercisse.Interfaces;
using _01_Exercisse.Models;

namespace _01_Exercisse.Services;

internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}
internal class MenuService : IMenuService
{

    private readonly IUserService _userService = new UserService();
    
    public void MainMenu()
    {
        bool exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Skapa en ny användare\n2. Visa en specifik användare\n3. Visa alla användare\n4. Ta bort användare\n0. Avsluta");
            Console.Write("Välj ett av ovanstående alternativ (0-4): ");
            var option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    CreateMenu();
                    break;
                    case "2":
                    ListSpecificMenu();
                    break;
                    case "3":
                    ListAllMenu();
                    break;
                    case "4":
                        EraseSpecificUser();
                    break;
                    case "0":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Felaktig inmatning, tryck enter för att fortsätta");
                    Console.ReadKey();
                    break;
            }
                
        } while(exit == false);
        Console.WriteLine("Programmet avslutades.");
        Console.ReadKey();
    }
    public void CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("Skapa en ny användare");
        Console.WriteLine("---------------------");

        var user = new UserCreateRequest();
        Console.Write("Ange förnamn: ");
        user.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Ange efternamn: ");
        user.LastName = Console.ReadLine()!.Trim();

        Console.Write("Ange e-postadress: ");
        user.Email = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Ange Lösenord: ");
        user.Password = Console.ReadLine()!.Trim();

        _userService.CreateUser(user);
        Console.WriteLine("En ny användare har blivit tillagd, tryck enter för att forstätta.");
        Console.ReadKey();
    }

    public void ListAllMenu()
    {
        Console.Clear();
        Console.WriteLine("Alla användare");
    
        Console.WriteLine("--------------");
        if (!_userService.GetAllUsers().Any()) // Bättre sätt att göra detta på?
              Console.WriteLine("Inga användare tillagda.");
            
        
        else
        {
            foreach (var user in _userService.GetAllUsers())
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
            }
        }
        
        Console.ReadKey ();
    }

    public void ListSpecificMenu()
    {
        Console.Clear();
        Console.WriteLine("Specifik användare");
        Console.WriteLine("------------------");
        Console.Write("Ange e-postadress: ");
        var email = Console.ReadLine()!.Trim().ToLower();
        var user = _userService.GetUser(user => user.Email == email);

        if (user != null)
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");              
        else
            Console.WriteLine($"Kunde inte hitta någon användare med e-postadressen <{email}>");

        Console.ReadKey ();
    }

    public void EraseSpecificUser()
    {
        Console.Clear();
        Console.WriteLine("Ta bort användare");
        Console.WriteLine("-----------------");
        Console.Write("Skriv in e-postadressen på den användare du vill ta bort: ");
        var email = Console.ReadLine()!.Trim().ToLower();
        var user = _userService.GetUser(user => user.Email == email);

        if (user != null)
        {
            _userService.DeleteUser(user);
            Console.WriteLine($"Användaren {user.FirstName} {user.LastName} togs bort.");
        }
        else
            Console.WriteLine($"Kunde inte hitta någon användare med e-postadressen <{email}>");

        Console.ReadKey();
    }
    

  
}
