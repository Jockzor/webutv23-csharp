using _02_Classes_GettersAndSetters.Models;
using System.Security.Cryptography;
using System.Text;

var customer = new Customer();
//set - sätt det värde
customer.FirstName = "Joacim ";
customer.LastName = "Edlund";


//get - hämta värdet
var name = customer.FullName;

var user = new User();
user.FirstName = "Joacim";
user.LastName = "Edlund";
user.Email = "Joacim.edlund@hotmail.com ";

// user.Password = "12345";
user.SetSecurePassword("Byt12345");
// var password = user.Password;

var password = Encoding.UTF8.GetString(user.Password);
