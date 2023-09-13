using Classes_Inheritance.Models;
using Classes_Inheritance.Services;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

internal class Program
{

    
    private static void Main(string[] args)
    {
        bool exit = false;

        do
        {

            Console.Clear();
            Console.WriteLine("Vad för typ av kund vill du skapa (p = privatperson, f = företag): ");
            var option = Console.ReadLine();

            switch (option!.ToLower())
            {
                case "p":
                    CustomerService.CreatePrivateCustomer();
                    break;

                case "f":
                    CustomerService.CreatePublicCustomer();
                    break;

                default:
                    break;

            }
            Console.Write("Vill du lägga till fler kunder? (j/n)");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "n") 
                exit = true;
        } while (!exit);
    }
}