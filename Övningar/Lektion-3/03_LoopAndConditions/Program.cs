namespace _03_LoopAndConditions
{
    internal class Program
    {
        static void printName()
        {
            Console.WriteLine("Hej från printName");
        }
        static void Main(string[] args)
        {
            printName();
            /*
             OPERANDER
            ---------------------------------------------------------------------------------
             ==     lika med
            !=      inte lika med
            <       mindre än
            >       störra än
            <=      mindre eller lika med
            >=      större eller lika med
            &&      och
            ||      eller
            !       inte
            ??      om första värdet är null välj det andra

            if(statement){}
            if(statement){} else {}
            if(statement){} else if(statement){} else {}

            (statement) ? do_this : else_do_this;

            
              */

            /*
            string firstName = "Jocke";
            string lastName = "";  //String.Empty // null!
            if(string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)) 
            {
                Console.WriteLine("Något av värdena saknas.");

            }
            else
            {
                Console.WriteLine("Namnen är inte lika.");
            }
            */

            /*
            string key = "black";
            switch(key) 
            {
                case "blue":
                    Console.WriteLine("black");
                    break;
            
            
                case "orange":
                    Console.WriteLine("orange");
                    break;
                
                
                case "gray":
                        Console.WriteLine("orange");
                        break;
                    
                    
                default:
                            Console.WriteLine("Go through");
                            break;
                        }
            */

            /*
             FOR-LOOP
            ---------------------------------------------------------------------------------------
            Vi loopar igenom en lista eller gör något ett givet antal gånger

            for (initialize value; condition; increment initialized value)
            {
            }
            for (int i = 0; i < 10; i++)
            {

            }
              */

            /*
             FOREACH-LOOP
             --------------------------------------------------------------------------}
            Vi loopar igenom alla objekt i en lista

            foreach(var object in list)
            {

            }

            ARRAYS
            ---------------------------------------------------------------------------------

            string[] names = new string[] { "Joacim", "Tommy", "Alex", };
            int[] numbers = new int[] { 1, 2, 3, 4 };
            string[] names = new string[10];
            names[0] = "Jocke";
            names[5] = "Tommy";
            names[9] = "Alex";
            foreach (string name in names) { Console.WriteLine(name); }
              */

            /*
            WHILE-LOOP
            --------------------------------------------------------------------------------------
            Gör en sak om och om igen tills ett tillstånd är uppnåt.
            Varav kontrollen sker i början
            while(statement)

            int number = 0;
            while (number < 10)
            {
                Console.WriteLine(number);
                number++;
            }


             */

            /*
              DO-WHILE LOOP
            -----------------------------------------------------------------------------------------
            Gör loopen minst en gång sedan kollar den tillståndet

            int number = 0;

            do
            {
                Console.WriteLine(number);
                number++;
            } while (number < 10);
             */



        }

    }
}