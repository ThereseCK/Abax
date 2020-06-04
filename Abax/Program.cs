using System;

namespace Abax
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Bil("NF123456", 147, 200, "Grønn", TransportKlasse.lettKjøretøy);
            bil1.Print();
            var bil2 = new Bil("NF654321", 150, 195, "Blå", TransportKlasse.lettKjøretøy);
            bil2.Print();
            bil1.Sammenligne(bil2, "Bil 1 0g Bil 2 ");
            bil1.kjør();

            var fly = new Fly("LN1234", 1000, 30, 2, 10, TransportKlasse.jetfly);
            fly.Print();
            fly.StartFly();

            var båt = new Båt("ABC123", 100, 30, 500);
            båt.Print();
        }
    }
}
