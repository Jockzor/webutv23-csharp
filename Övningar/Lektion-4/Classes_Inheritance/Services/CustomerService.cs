

using Classes_Inheritance.Models;
using System.Security.Cryptography.X509Certificates;

namespace Classes_Inheritance.Services;

internal class CustomerService
{
    private static List<Customer> _customerList = new List<Customer>();
    public static void CreatePrivateCustomer()
    {
        var customer = new PrivateCustomer();
        
        Console.WriteLine("Ange förnamn: ");
        customer.FirstName = Console.ReadLine()?? "";
        Console.WriteLine("Ange efternamn:");
        customer.LastName = Console.ReadLine()??"";
        Console.WriteLine("Ange e-post: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.WriteLine("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine();

        _customerList.Add(customer);
        Console.WriteLine("En ny privatkund har lagts till i listan.");
        Console.ReadKey();
    }
    public static void CreatePublicCustomer() 
    {
    var customer = new CompanyCustomer();
     

        Console.WriteLine("Ange företagnamn: ");
        customer.CompanyName = Console.ReadLine() ?? "";
        Console.WriteLine("Ange e-post: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.WriteLine("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        _customerList.Add(customer);
        Console.WriteLine("En ny företagskund har lagts till i listan.");
        Console.ReadKey();
    }
}
