using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Value_Semantics;

namespace _02_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Matematiska modeller
            Vector2D vector = new Vector2D(3.0, 4.0);
            Console.WriteLine($"Vector: X={vector.X}, Y={vector.Y}");

            //Interoperabilitet
            Todo todo = new Todo { userId = 1, id = 1, title = "delectus aut ateum", completed = false };
            Console.WriteLine($"Todo: {todo.userId}{todo.id}-{todo.title} {todo.completed}");

            //Prestandakänsliga applikationer
            RgbColor rgbColor = new RgbColor(255, 0, 0);
            Console.WriteLine($"Color: R={rgbColor.R} G={rgbColor.G} B={rgbColor.B}");

            //Värdesemantik
            Money salary = new Money(5000M, "SEK");
            Console.WriteLine($"Money: Amount={salary.Amount}, Currency={salary.Currency}");

            //Domain Driven Desing(DDD)
            User user = new User 
            {FirstName = "Joacim",
             LastName = "Edlund",
            Email = new Email("joacim@domain.com"),
            Password = new Password("BytMig123!")
            };
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
            Console.ReadKey();  
        }
    }
}