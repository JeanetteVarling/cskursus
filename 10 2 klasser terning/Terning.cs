using System;

namespace _10_2_klasser_terning
{
    //En privat(private) statisk(static) og ny instans af System.Random kaldet rnd
    //En metode Skriv() som udskriver værdien(evt som [2] eller[4])
    //En metode Ryst() som sætter værdi til en tilfældig værdi mellem 1-6 rnd.Next(1, 7). Dette skal dog kun ske hvis snyd = false. Hvis snyd = true så skal værdi sættes til 6.

    //En custom constructor med en bool argument, der sætter værdi til en 1 og snyd til den givne værdi
    class Terning
    {
        //Bemærk - en instans af System.Random kan erklæres således i selve klassen:
        //private static Random rnd = new Random();
        //En offentlig(public) int værdi
        //En privat(private) bool snyd
        private static Random rnd = new Random();
        public int værdi;
        private bool snyd;

        //En privat(private) statisk(static) og ny instans af System.Random kaldet rnd ??



        //En default constructor der sætte værdi til 1 og snyd til false
        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }

        //En metode Skriv() som udskriver værdien(evt som [2] eller[4])
        public void Skriv()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Værdi" + "[" + this.værdi + "]");
            Console.Write(" - Snyd" + "[" + this.snyd + "]");
        }


        //En metode Ryst() som sætter værdi til en tilfældig værdi mellem 1-6 rnd.Next(1, 7). Dette skal dog kun ske hvis snyd = false. Hvis snyd = true så skal værdi sættes til 6.
        public void Ryst()
        {
            if (snyd)
            {
                this.værdi = 6;
            }
            else
            {
                this.værdi = rnd.Next(1, 7);
            }
        }
    }
}
