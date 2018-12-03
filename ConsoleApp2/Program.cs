using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //        Tilføj kode til main:

            //Opret en ny person med Person k1 = new Person(); (så felter sættes til default værdi – best pratice)
            //        Sæt k1.navn = ”a”
            Person k1 = new Person();
            k1.navn = "a";

            //Opret en ny person med Person k2 = new Person();
            Person k2 = new Person();

            //Sæt k2.navn = ”b”
            k2.navn = "b";
            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            //Udskriv k1.navn og k2.navn

            //        Sæt k1 = k2;

            k1 = k2;

            //        Udskriv k1.navn og k2.navn

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            //        Sæt k1.navn = ”c”
            //Udskriv k1.navn og k2.navn
            k1.navn = "C";
            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            //        Hvad skriver den ud – og hvorfor??
            //Prøv nu at
            //        Rette struct Person til class Person
            //Hvad skriver den ud – og hvorfor??


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        } }

    //Opret en ny konsol app og tilføj en struct kaldet Person med et offentligt string felt kaldet navn:
    //struct Person
    struct Person

    {
            public string navn;
        }
    }