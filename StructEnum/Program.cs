using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.csv;
            Console.WriteLine("");
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);


            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            p.Køn = "Mand";
            Console.WriteLine("");
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Køn);

            Person p10 = new Person();
            p10.Id = 10;
            p10.Navn = "Jeanette";
            p10.Køn = "Kvinde";
            Console.WriteLine("");
            Console.WriteLine(p10.Id);
            Console.WriteLine(p10.Navn);
            Console.WriteLine(p10.Køn);

            Person p11 = new Person();
            p11.Id = 11;
            p11.Navn = "Anna";
            p11.Køn = "Kvinde";

            Console.WriteLine("");
            Console.WriteLine(p11.Id);
            Console.WriteLine(p11.Navn);
            Console.WriteLine(p11.Køn);



            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
    public struct Person

    {

        public int Id;
        public string Navn;
        public string Køn;


    }

    


    public enum FilTyper { pdf, txt, csv }
}
    
