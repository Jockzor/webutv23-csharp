

using System.Runtime.CompilerServices;

namespace _01_Classes.Models;

internal class Customer
{
    // model = 90% Properties

    //Properties
    public Customer(string firstName, string lastName, string email, string address)
    {
            FirstName = firstName;
        LastName = lastName;
        Email = email;
            Address = address;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    //Methods

    public override string ToString()
    {
        return FirstName + this.LastName + this.Email + this.Address;
    }



}
