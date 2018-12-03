using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_klasser
{
    class Program
    {
        static void Main(string[] args)
        {



            //Brug klassen i Main ved at skabe en 2 - 3 objekter med new og test at metoderne virker.
            Person p1 = new Person();

            p1.Efternavn = "Varling";

            p1.Fornavn = "Sia";

            p1.Foedselsaar = 1965;

            Console.WriteLine(p1.FuldtNavn());

            Console.WriteLine(p1.Alder());





            Person p2 = new Person("Anna", "Varling", 1995);

            Console.WriteLine(p2.FuldtNavn());

            Console.WriteLine(p2.Alder());



            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    } 


    // instans på Heap
    //Du skal skabe en tom konsol app med en klasse Person med følgende medlemmer:
    //Et offentlig string felt kaldet Fornavn
    //Et offentlig string felt kaldet Efternavn
    //Et offentlig int felt kaldet Fødselsår
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Foedselsaar;

        //En offentlig metode FuldtNavn() som returnerer Fornavn + ” ” + Efternavn
        public string FuldtNavn() {
            return $"{Fornavn} {Efternavn}";

            //Console.WriteLine(Fornavn + " " + Efternavn);
        }

        //En offentlig metode Alder() der beregner en estimeret alder ud fra fødselsår
        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.Foedselsaar;
        }


        //En default constructor som sætter Fornavn og Efternavn til ””
        // bruges til log, sikkerhed og initialisering
        public Person()
        {
            this.Fornavn = " ";
            this.Efternavn = " ";
        }

        //En custom constructor som initialiserer alle felter
        public Person(string fornavn, string efternavn,int foedselsaar)
        {
            this.Foedselsaar = foedselsaar;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }

}
