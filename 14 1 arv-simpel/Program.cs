using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_arv_simpel
{
    class Program
    {
        // Du skal skabe en tom konsol app 
        // Brug klassen i Main ved at skabe et objekt med new og test at det virker.
        // Skab herefter en klasse Elev og en klasse Instruktør som arver fra Person.
        // Elev har sin egen string egenskab Klasselokale og Instruktør sin egen int egenskab NøgleId.
        // Prøv at skabe objekter af det tre klasser og udskriv resultatet af FuldtNavn.
        static void Main(string[] args)
        {
        }

        // En klasse Person med følgende medlemmer:
        // En egenskab kaldet Fornavn(implementeret som en automatisk egenskab – brug ”prop” + tab)
        // En egenskab kaldet Efternavn(implementeret som en automatisk egenskab – brug ”prop” + tab)
        // En metode kaldet FuldtNavn som returnerer Fornavn + ” ” + Efternavn
        class Person
        { 
            public string Fornavn { get; set; }
            public string Efternavn { get; set; }

            public string FuldtNavn()
            {

                return $"{Fornavn} {Efternavn}";

            }
        }
    }
}
