

using _01_Classes.Models;

namespace _01_Classes.Services
{
    internal class CustomerService
    {
        // service = 90% Methods

        //fields
        private List<Customer> _customerList = new List<Customer>();
        

        
        //Methods(propertyName)
        public void CreateUser(Customer customer)
        {
            _customerList.Add(customer);
        }
        public List<Customer> GetCustomers() 
        {
            return _customerList;
        }
        public void GetCustomer()
        {
           
        }
        public void UpdateCustomer() { }
        public void DeleteCustomer() { }

       

    }
}
