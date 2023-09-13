using System.ComponentModel.DataAnnotations;

namespace _01_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* String - Till för text
             
             string firstName = "Joacim";
            var lastName = "Edlund";
           
            string firstName = "Joacim";
            var lastName = "Joacim Edlund";

            string sentence = "Jag är \"bäst\" i hela världen";
            string uri_1 = "c:\\users\\jocke\\document";
            string uri_2 = @"c:\users\jocke\document";

            string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
            string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
            string placeholder_3 = string.Format("Hej jag heter {0}{1}.", firstName, lastName);
            
            

            string email = "Joacim";
            Console.WriteLine($"Original: {email}");
            Console.WriteLine($"ToUpper: {email.ToUpper()}");
            Console.WriteLine($"ToLower: {email.ToLower()}");

            string firstName = "Joacim       ";
            string lastName = "Edlund";
            Console.WriteLine($" {firstName} {lastName}");
            Console.WriteLine($" {firstName.Trim()} {lastName.Trim()}");

            string sentence = "Här har vi en text som är på svenska.";
            Console.WriteLine(sentence.Replace("ä", "a").Replace("å","a"));

            string name = "Joacim Edlund";
            string domain = "domain.com";

            string emailaddress = $"{name}@{domain}";
            Console.WriteLine(emailaddress);
            emailaddress = emailaddress.Replace(" ", ".").ToLower();
            Console.WriteLine(emailaddress);
            */

            /*
             INTEGRALS & FLOATING POINTS
            ------------------------------------------------------------------------------------

            Type    Bits    RANGE(min, max)
            ------------------------------------------------------------------------------------
           *byte    8       0       255
            sbyte   8       -128    127
            short   16      -32768  32767
            ushort  16      0       65535
           *int     32      -2 147 483 648     2 147 483 647 
            uint    32      0                  4 294 967 295
           *long    64      -9,223,372,036,854,775,808   9,223,372,036,854,775,807
            ulong   64      0                           18,446,744,073,709,551,615
            
            Type    Bytes       DECIMAL RANGE       SUFFIX
            --------------------------------------------------------------------------------------
            float   4           6-9 digits      f eller stora F
            double  8           15-16 digits    inget eller d eller D
           *decimal 16          28-29 digits    m eller M

            

            float floatValue = 0.1f + 0.1f + 0.1f;  //0.3
            Console.WriteLine(floatValue);

            double doubleValue = 0.1 + 0.1 + 0.1; //0.300000000004 ish
            Console.WriteLine(doubleValue);

            decimal decimalValue = 0.1m + 0.1m + 0.1m;
            Console.WriteLine(decimalValue);

            float = 1.123456789f;
            double = 1.123456789012345;
            decimal = 1.1234567890123456789012345678m;

            */

            /*
                BOOLEAN - Sant/falskt
                TYPE            Bits    
            ------------------------------------------------------------------------------------------
            bool                0/1         false/true

            bool isEnabled = false;
            bool isActive = true;
             */

            /*
             GUID/UUID /GLoabally Unique Identifier)
            ------------------------------------------------------------------------------------------
            Guid            16 bytes        Guid.NewGuid();      59a46376-e61e-45de-8b28-0160c791e87b   
             

            Guid userId = Guid.NewGuid();
            Console.WriteLine(userId);
            */

            
            Console.ReadKey();
        }
    }
}