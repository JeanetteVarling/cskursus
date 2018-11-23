using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgvariabler
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            
            string samleNavn = fornavn + " " + efternavn;
            
            Console.WriteLine();
            Console.WriteLine("*** Samle");
            Console.WriteLine(samleNavn);

            string navnLille = samleNavn.ToLower();

            Console.WriteLine();
            Console.WriteLine("ToLower");
            Console.WriteLine(navnLille);

            string navnStort = samleNavn.ToUpper();
            Console.WriteLine();
            Console.WriteLine("ToUpper");
            Console.WriteLine(navnStort);


            string del = samleNavn.Substring(7, 4);
            Console.WriteLine();
            Console.WriteLine("Del 7,4 ");
            Console.WriteLine(del);

            string del2 = samleNavn.Substring(1, 4);
            Console.WriteLine();
            Console.WriteLine("Del 2,4 ");
            Console.WriteLine(del2);


            Console.WriteLine();
            Console.WriteLine("r n t ");
            Console.WriteLine(fornavn + "\r\n\t" + efternavn + "\r" + fornavn );


            System.IO.File.WriteAllText("c:\\temp\\test.txt", samleNavn);

            System.IO.File.WriteAllText("c:\\temp\\JEAV test.txt", "Jeanette Varling");



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
