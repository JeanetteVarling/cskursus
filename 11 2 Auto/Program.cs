using System;

namespace _11_2_Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brug klassen i Main ved at skabe et objekt med new og test at det virker.
            Person p = new Person();
            Console.WriteLine("..Brug klassen i Main ved at skabe et objekt med new og test at det virker.");
            p.Fornavn = "Sia";
            p.Efternavn = "Varling";
            Console.WriteLine(p.FuldtNavn());

            Console.WriteLine(p.personegenskab);

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine(" ");
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        //Du skal skabe en tom konsol app med en klasse Person med følgende medlemmer:

        //En egenskab kaldet Fornavn(implementeret som en automatisk egenskab – brug ”prop” +tab)
        class Person
        {
            public string Fornavn { get; set; }

            //En egenskab kaldet Efternavn(fuld egenskab med et privat felt kaldet efternavn – brug ”propfull+tab).
            //Når der tildeles skal efternavn være større end 3 tegn – ellers sæt efternavn til ””

            private string efternavn;
            public string Efternavn
            {
                    
                get
                {
                    Console.WriteLine("..En egenskab kaldet Efternavn(fuld egenskab med et privat felt kaldet efternavn");
                    return efternavn;
                }
                set
                {
                    if (value.Length < 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("....Mindre end 3 tegn – ellers sæt efternavn til blank");
                        efternavn = "";
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("....Når der tildeles skal efternavn være større end 3 tegn – efternavn = value");
                        efternavn = value;
                    }
                }

            }

            //En metode kaldet FuldtNavn som returnerer Fornavn + ” ” +Efternavn.
            public string FuldtNavn()

            {
                Console.WriteLine("..Metode kaldet FuldtNavn som returnerer");
                return Fornavn + " " + Efternavn;

            }

            // Overvej om det bør være en egenskab i stedet? Hvad er forskellen?
            public string personegenskab
            {
                get
                {
                    Console.WriteLine("..Egenskab kaldet personegensakb som returnerer ");
                    return Fornavn + " " + Efternavn;
                }

            }

        }
    }
}
