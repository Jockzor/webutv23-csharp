using _03_Classes_Constructors.Models;

namespace _03_Classes_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer_1 = new Customer();

            customer_1.Id = 1;
            customer_1.Name = "Joacim";
            customer_1.Email = "joacim@mail.com";

            var customer_2 = new Customer()
            {
                Id = 1,
                Name = "Joacim",
                Email = "joacim@mail.com"
            };

            var customer_3 = new Customer("Joacim", "joacim.edlund@mail.com");

            
        }
    }
}