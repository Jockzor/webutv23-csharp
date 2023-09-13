






using _04_ClassesAndLists.Models;
using System.Reflection.Metadata;

namespace _04_ClassesAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
 LISTS
---------------------------------------------------------------------------------------------------------
En lista är en dynamisk lista som gör att det går att lägga till och ta nort objekt ifrån listan. 
Det går även att sortera om den.
Det finns lite olika type av listor för olika ändamål.
            Instansiera en ny lista:
            ----------------------------------------
            List<int> list = new List<int>();
            var list = new List<string>();
            List<string> list = new();

            List<>           ReadWrite      lägga till, ta bort, sortera
            IEnumerable<>    Read           sortera
            ICollection<>   ReadWrite       lägga till, ta bort, sortera
            ObservableCollection 

            * I betyder Interface och har då en uppsättning av funktioner vi kan komma åt och göra något med.
           

              List<string> list1 = new List<string>();
            list1.Add("1");
            list1.Remove("1");
            list1.OrderByDescending(x => x);
            list1.Clear();
            list1.FirstOrDefault();
            list1.LastOrDefault();
            list1.Insert(0, "2");

            IEnumerable<string> list2 = new List<string>();
            list2.Add("1");
            list2.Remove("1");
            list2.OrderByDescending(x => x);    
            list2.Clear();
            list2.FirstOrDefault();
            list2.LastOrDefault();
            list2.Insert(0, "2");

            ICollection<string> list3 = new List<string>();
            list3.Add("1");
            list3.Remove("1");
            list3.OrderByDescending(x => x);
            list3.Clear();
            list3.FirstOrDefault();
            list3.LastOrDefault();
            list3.Insert(0, "2");


            var names = new List<string>();

            names.Add("Jocke");
            names.Add("ALex");
            names.Add("Tommy");

            foreach (var name in names)
            {

                Console.WriteLine(name);
            }
            Console.WriteLine();

            var user = names.FirstOrDefault(name => name.ToLower() == "Jocke");
            Console.WriteLine(user);
            if(user != null)
            {
                Console.WriteLine(user);
            }
            else
                Console.WriteLine("Användaren hittades inte.");
 * */

            /*
             CLASSES
            ------------------------------------------------------------------------------------------------
            Klasser är en del av objektorienterad programmering.
            En klass är alltsp ett objekt och en klass kan innehålla flera olika saker.
            Se en klass som en mall över hur något ser ut eller hur något är.

            En bil, en användare, en kund, en order, en prislista, en adress, ett kontaktformulär
            ....det kan vara vad som helst i systemet.

                class ContactPerson
        {
            // Properties och skrivs med Pascal
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }

        }
             * */

            

            var contactPersons = new List<ContactPerson>();
            var answer = "n";
            do
            {
                Console.Clear();
                var contactPerson = new ContactPerson();

                Console.Write("First name: ");
                contactPerson.FirstName = Console.ReadLine() ?? "";

                Console.Write("Last name: ");
                contactPerson.LastName = Console.ReadLine() ?? "";

                Console.Write("Email: ");
                contactPerson.Email = Console.ReadLine() ?? "";

                Console.Write("Phhone number: ");
                contactPerson.PhoneNumber = Console.ReadLine() ?? "";

                // Lägg till kontaktpersonen till listan
                contactPersons.Add(contactPerson);

                Console.Write("Vill du lägga till en till person? (y/n: ");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y");

            Console.WriteLine("Här är alla kontaktpersoner");
            foreach(var contact in contactPersons) 
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName}{contact.Email}{contact.PhoneNumber}");
            }
        }
    }
}
