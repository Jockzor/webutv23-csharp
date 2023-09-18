using _01_SaveAndReadToFromFile.Models;
using _01_SaveAndReadToFromFile.Services;
using System.ComponentModel.DataAnnotations;

namespace _01_SaveAndReadToFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customerService = new CustomerService();
            customerService.GetCustomers();

            var customer = new Customer
            {
                firstName = "Joacim",
                lastName = "Edlund",
                email =" mejl@mejl"


            };

            
            customerService.AddCustomerToList(customer);
            Console.ReadKey();

            /* Json = JavaScript Object Notation
            "key": "value"

            {
             "firstName" : "Joacim",
            "lastName" : "Edlund",
            "age" : 30,
            "isActive" : false,
            "skills" : ["C#"]
            "relatives" : [
                            "firstName" : Malin, "lastName : "Edlund",
                             "firstName" : Rebecca, "lastName : "Edlund"
                          ]
             }


             */
        }
    }
}