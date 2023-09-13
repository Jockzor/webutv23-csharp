using _01_Classes.Models;
using _01_Classes.Services;
using System.Security.Cryptography.X509Certificates;

namespace _01_Classes
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            /* Access Modifiers
            ---------------------------------------------------------------------------------------
            private     accessbar bara inom scopet (dvs{}) som variabeln ligger inom.
            public      accessbar överallt i hela din solution, dvs även mellan olika projekt
            internal    accessbar överallt i hela ditt projekt, men inte mellan olika projekt

            */
            // Vi gör en instans av en customerService så vi kan använda den
            var customerService = new CustomerService();
           
            customerService.CreateUser(new Customer("Jocke", "Edlund", "hotmail", "Aspnäs"));

           

           
            
            
            foreach(Customer _customer in customerService.GetCustomers())
            { Console.WriteLine(_customer); }



        }
    }
}