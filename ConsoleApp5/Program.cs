using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
//Brug ikke automatiske egenskaber… Skriv dem fuldt(propfull)
//Ekstra:

//Tilføj eventuelt en custom constructor hvor pris og navn kan angives(men man skal også kunne oprette en instans uden argumenter – så husk en tom default constructor).


        static void Main(string[] args)
        {
            //Der skal logges(console.writeline) når der aflæses og tildeles en værdi til Navn og Pris
            Console.WriteLine("New Vare .........................");
            Vare v = new Vare();

            v.Navn = "vare #1";

            v.Pris = 100;

            Console.Write(v.Navn);
            Console.WriteLine(v.Pris);
            Console.WriteLine("Metodekald til PrisMedMoms " + " Navn " + v.Navn + " Pris " + v.Pris + " Beregnet Mons " + v.PrisMedMoms());


            Console.WriteLine("New Vare .....................");
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(" ");
          
            Console.Write(v2.Navn);        
          
            Console.WriteLine(v2.Pris);
            Console.WriteLine("Metodekald til PrisMedMoms " + " Navn " + v2.Navn + " Pris " + v2.Pris +" Beregnet Mons " + v2.PrisMedMoms());
            Console.WriteLine(v2.PrisMedMoms());

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine(" ");
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Vare
    {
        //man skal også kunne oprette en instans uden argumenter – så husk en tom default constructor).

        public Vare()

        {
            Console.WriteLine("nu i public Vare() - oprette en instans uden argumenter");
        }

        //Tilføj eventuelt en custom constructor hvor pris og navn kan angives
        public Vare(string navn, double pris)

        {

            this.Pris = pris;

            this.Navn = navn;
            Console.WriteLine("nu i public Vare(string navn, double pris) - custom constructor hvor pris og navn kan angives");

        }
        //private felt kaldet navn)
        private string _navn;

        //En offentlig egenskab(string) Navn(med private felt kaldet navn)
        public string Navn
        {
            get
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nu aflæses navnet via get ");
                return _navn;
            }
            set
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nu tildeles navn via set og value ");
                _navn = value;
            }
        }


        //En offentlig egenskab(double) Pris(med private felt kaldet pris)
        //private felt kaldet navn)
        private double _pris;

        public double Pris
        {
            get
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nu aflæses pris via get");
                return _pris;
            }
            set
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nu tildeles pris via set og value");
                _pris = value;
            }
        }

        //En offentlig metode PrisMedMoms
        public double PrisMedMoms()

        {

            return this._pris * 1.25;

        }

    }
}
