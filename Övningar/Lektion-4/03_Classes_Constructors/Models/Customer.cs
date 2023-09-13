

namespace _03_Classes_Constructors.Models
{
    internal class Customer
    {
        public Customer()
        {
            Name = "";
            Email = "";
            Address = "";
        }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            Address = "";
        }
        public Customer(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
