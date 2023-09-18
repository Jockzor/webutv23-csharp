

using _01_SaveAndReadToFromFile.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace _01_SaveAndReadToFromFile.Services;

internal class CustomerService
{
    private List<Customer> _listOfCustomers = new List<Customer>();
    public void AddCustomerToList(Customer customer)
    {
        _listOfCustomers.Add(customer);

        var json = JsonConvert.SerializeObject(_listOfCustomers);
        FileService.SaveToFile(json);
    }

   

    public void GetCustomers()
    {
        var content = FileService.ReadFromFile();
        if(!string.IsNullOrEmpty(content))
            _listOfCustomers = JsonConvert.DeserializeObject<List<Customer>>(content)!;

         foreach(var customer in _listOfCustomers)
            {
            Console.WriteLine($"{customer.firstName} {customer.lastName} <{customer.email}>");
            }
    }
}
