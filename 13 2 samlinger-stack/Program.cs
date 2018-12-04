using System;
using System.Collections.Generic;

namespace _13_2_samlinger_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            Console.WriteLine(" Spar, Værdi = 2");

            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            Console.WriteLine(" Hjerter, Værdi = 14");

            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            Console.WriteLine(" LI=Ruder, Værdi = 3");


            Console.WriteLine(" ");
            Console.WriteLine(" Vis efter 3*Tilføjkort");
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            Console.WriteLine(" Vis efter Fjernkort");
            b.Vis();


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Kort
        {
           
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                Console.WriteLine("public class Kort");
                return this.Kulør + " " + this.Værdi;
            }
        }

        //        Din opgave er at skabe en klasse Bunke som kan bruges til at gemme kort.
        class Bunke
        {
            //LIFO
            //        Klassen bør opbevare kort i en privat Stack.
         
            private Stack<Kort> bunke = new Stack<Kort>();

            //Den skal have metoderne TilføjKort(Kort),
            public void TilføjKort(Kort k)
            {
                Console.WriteLine("LIFO - Klassen bør opbevare kort i en privat Stack via push til bunke");
                bunke.Push(k);
            }

            //        FjernKort der returnerer et kort,
            public Kort FjernKort()
            {
                Console.WriteLine("...   FjernKort der returnerer et kort via Pop");
                if (bunke.Count > 0)
                {
                    return bunke.Pop();
                }

                return null;
            }

            //        og en Vis der viser alle kort i bunken.
            public void Vis()
            {
                foreach (var item in bunke)
                {
                    Console.WriteLine("...   Vis der viser alle kort i bunken via foreach");
                    if (bunke.Count > 0)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}

