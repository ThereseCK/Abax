using System;
using System.Collections.Generic;
using System.Text;

namespace Abax
{
    public class Bil : Kjøretøy
    {
        public string Farge { get; }
        public Bil(string kjennetegn, decimal Effekt, decimal MaksFart, string Farge, TransportKlasse transportKlasse) : 
            base(kjennetegn, Effekt, MaksFart, transportKlasse)
        {
            Farge = Farge;
        }
        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(Farge), Farge);
        }

        public void kjør()
        {
            Console.WriteLine(nameof(Bil) + " " + Kjennemerke + " Kan starte å kjøre ");
            Console.WriteLine();
        }
    }
}
