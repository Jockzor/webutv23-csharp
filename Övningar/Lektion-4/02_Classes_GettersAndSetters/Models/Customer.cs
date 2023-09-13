
namespace _02_Classes_GettersAndSetters.Models
{
    internal class Customer
    {
        // public string FirstName { get; set; }
        private string firstName;

        public string FirstName //value
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";   
    }
}
