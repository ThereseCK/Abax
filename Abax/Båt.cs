using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Abax
{
    public  class Båt : Kjøretøy
    {
        public decimal BruttoTonnasje { get; }

        public Båt(string kjennemerke, decimal effekt, decimal maksFart, decimal bruttotonnasje) : base(kjennemerke, effekt, maksFart, null)
        {
            BruttoTonnasje = bruttotonnasje;
            Enheter.Add(nameof(BruttoTonnasje), "kg");
            Enheter[nameof(MaksFart)]= "Knop";

        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(BruttoTonnasje), BruttoTonnasje);
        }
    }
}
