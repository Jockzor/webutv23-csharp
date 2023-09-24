using _03_Records.Records;
using System.Net.NetworkInformation;

namespace _03_Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Joacim", "Edlund", "joacim@domain.com");
           // user.firstName = "Joacim"; <---- det här går inte pga Record
            Console.WriteLine($"{user.firstName} {user.lastName} <{user.email}>");

            Console.ReadKey();
        }
    }
}