using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgNy
{
    class Program
    {
        static void Main(string[] args)
        {
            {



                int heltal = 10;
                string ss = "++";

                heltal++;
                Console.WriteLine(ss);
                Console.WriteLine($"Heltal = {heltal}");

                ss = "--";
                heltal--;
                Console.WriteLine(ss);
                Console.WriteLine($"Heltal = {heltal}");


                ss = "+=20";
                heltal += 20;
                Console.WriteLine(ss);
                Console.WriteLine($"Heltal = {heltal}");



                double kommatal = 12.5;
                Console.WriteLine();
                Console.WriteLine($"Kommatal = {kommatal}");

                ss = "kommatal++";
                kommatal++;
                Console.WriteLine();
                Console.WriteLine(ss);
                Console.WriteLine($"Kommatal = {kommatal}");

                kommatal--;
                ss = "kommatal--";
                Console.WriteLine();
                Console.WriteLine(ss);
                Console.WriteLine($"Kommatal = {kommatal}");

                kommatal *= 2;

                ss = "kommatal*= 2";
                Console.WriteLine();
                Console.WriteLine(ss);
                Console.WriteLine($"Kommatal ={kommatal}");





                // Hold console åben ved debug

                if (System.Diagnostics.Debugger.IsAttached)

                {

                    Console.Write("Press any key to continue . . . ");

                    Console.ReadKey();

                }



            }
        }
    }
}
