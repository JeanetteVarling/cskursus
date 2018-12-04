using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
//    Du skal skabe en tom konsol app med følgende klasse:
    class Program
    {
        static void Main(string[] args)
        {
            //    Sørg for at skabe en instans af en generisk liste som kan arbejde med en Person.
            Console.WriteLine("...generisk List...");
            List<Person> instansX = new List <Person>();

            //    Tilføj 3 forskellige personer
            Console.WriteLine("...  Tilføj 3 forskellige Varling personer");
            instansX.Add(new Person() { Id = 1, Navn = "Henrik Varling" });
            instansX.Add(new Person() { Id = 2, Navn = "Sia Varling" });
            instansX.Add(new Person() { Id = 3, Navn = "Ditte Varling" });

            //    Skriv dem ud i en ForEach
            Console.WriteLine("...  Skriv dem ud i en ForEach");
            foreach (var item in instansX)
            {
                Console.WriteLine(item.Navn);
            }


            //    Prøv også at skabe en generisk Dictionary hvor nøglen er en int og værdien af en instans af en Person.
            Console.WriteLine("...generisk Dictionary...");
            Dictionary<int, Person> instansD = new Dictionary<int, Person>();

            //Tilføj 3 forskellige personer
            Console.WriteLine("... Tilføj 3 forskellige Olsen personer");
            instansD.Add(1, new Person() { Id = 1, Navn = "Oluf Olsen" });

            instansD.Add(2, new Person() { Id = 2, Navn = "Lene Olsen" });

            instansD.Add(3, new Person() { Id = 3, Navn = "Betina Olsen" });

            //find en person udfra nøglen(lst[x]).
            Console.WriteLine("... find en person udfra nøglen(lst[x]).");
            var b = instansD[3];
            Console.WriteLine(b.Navn);

            var l = instansD[2];
            Console.WriteLine(l.Navn);

            var o = instansD[1];
            Console.WriteLine(o.Navn);



            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    // class Person
    //    {
    //        public int Id { get; set; }
    //        public string Navn { get; set; }
    //    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
