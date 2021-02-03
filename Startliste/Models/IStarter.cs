using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    public interface IStarter
    {
        string Vorname { get; set; }
        string Nachname { get; set; }
        string Geschlecht { get; set; }
        string Nation { get; set; }
        int Startnummer { get; set; }


    }
}
