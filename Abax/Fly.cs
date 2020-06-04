using System;
using System.Collections.Generic;
using System.Text;

namespace Abax
{
    public class Fly : Kjøretøy
    {
        public decimal VingeSpenn { get; }
        public decimal Lasteevne { get; }
        public decimal EgenVekt { get; }


        public Fly(string kjennemerke, decimal effekt, decimal vingespenn, decimal lasteevne, decimal egenvekt, TransportKlasse type) :
            base(kjennemerke, effekt, null, type)
        {
            VingeSpenn = vingespenn;
            Lasteevne = lasteevne;
            EgenVekt = lasteevne;
            Enheter.Add(nameof(VingeSpenn), "m");
            Enheter.Add(nameof(Lasteevne), "tonn");
            Enheter.Add(nameof(EgenVekt),"tonn");
        }

        public override void ToStringOptional(StringBuilder text)
        {
            base.ToStringOptional(text);
            Add(text, nameof(VingeSpenn), VingeSpenn);
            Add(text, nameof(Lasteevne), Lasteevne);
            Add(text, nameof(EgenVekt), EgenVekt);
        }

        public void StartFly()
        {
            Console.WriteLine(nameof(Fly) + " " + Kjennemerke + " har fått bedskjed om å fly ! ");

            Console.WriteLine("-----------------------------");
        }
    }
}
