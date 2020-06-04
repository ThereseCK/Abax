using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Abax
{
    public class Kjøretøy
    {
    public string Kjennemerke { get; }
    public decimal Effekt { get; }
    public decimal? MaksFart { get; }
    public TransportKlasse? type { get; }


    public Kjøretøy(string kjennemerke, decimal effekt, decimal? maksFart, TransportKlasse? type)
    {
        Kjennemerke = kjennemerke;
        Effekt = effekt;
        this.MaksFart = maksFart;
        this.type = type;
    }
    protected Dictionary<string, string> Enheter = new Dictionary<string, string>
    {
        {nameof(MaksFart), "km/t" },
        {nameof(Effekt), "kw" },
    };
        public override string ToString()
    {
        var text = new StringBuilder();
        text.AppendLine(GetType().Name);
        Add(text, nameof(Kjennemerke), Kjennemerke);
        Add(text, nameof(MaksFart), MaksFart);
        Add(text, nameof(Effekt), Effekt);
        ToStringOptional(text);
        return text.ToString();
    }
    protected void Add(StringBuilder text, string name, object value)
    {
        if (value == null) return;
        text.Append("  ");
        text.Append(name);
        text.Append("=");
        text.Append(value);
        if (Enheter.ContainsKey(name)) text.Append(Enheter[name]);
        text.AppendLine();
    }
        public virtual void ToStringOptional(StringBuilder text)
    {
        Add(text, nameof(TransportKlasse), type);
    }

        public void Print()
    {
        Console.WriteLine(ToString());
    }
    public void Sammenligne(Kjøretøy kjøretøy2, string prefix)
    {
        var erLike = Equals(kjøretøy2);
        var erLikeTekst = erLike ? string.Empty : "ikke";
        Console.Write(prefix);
        Console.WriteLine(" er {0} samme kjøretøy.", erLikeTekst);
        Console.WriteLine();
    }
    }
    
    
}
