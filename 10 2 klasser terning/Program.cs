using System;

namespace _10_2_klasser_terning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _10_2_klasser_terning
    {
        class Program
        {
            static void Main(string[] args)
            {
                Terning t1 = new Terning();
                Console.WriteLine("Terning t1 .............");
                t1.Skriv();
                t1.Ryst();
                t1.Skriv();
                
                Terning t2 = new Terning(true);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Terning t2 --------------");
                t2.Skriv();
                t2.Ryst();
                t2.Skriv();

                // Hold console åben ved debug
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press any key to continue . . . ");
                    Console.ReadKey();

                }
            }
        }
    }

}
