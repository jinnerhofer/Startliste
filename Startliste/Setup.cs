using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    public class Setup
    {
        static void Main(string[] args)
        {
            //Gemeinsam mit Anna Streitberger gemacht

            List<IStarter> Startliste = new List<IStarter>();

             int Zahl = 1;

            while (Zahl < 0)
            {
                var Startnummer = Zahl; 
                Console.Write("Vorname: ");
                var Vorname = Console.ReadLine();
                Console.Write("Nachname: ");
                var Nachname = Console.ReadLine();
                Console.Write("Geschlecht: ");
                var Geschlecht = Console.ReadLine();
                Console.Write("Nation: ");
                var Nation = Console.ReadLine();
                Startnummer++;

                foreach (Starter s in Startliste)
                {
                    Startliste.Add(new Starter());
                    Console.WriteLine(s);
                }
            }
            
        }
    }
}
