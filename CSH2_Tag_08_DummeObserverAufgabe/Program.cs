using System;

namespace CSH2_Tag_08_DummeObserverAufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Mausefalle falle1 = new Mausefalle("Wohnzimmer");
            Mausefalle falle2 = new Mausefalle("Keller");
            Mausefalle falle3 = new Mausefalle("Küche");

            Katze k1 = new Katze("Kenny");
            Katze k2 = new Katze("Rocky");

            falle1.Subscribe(k1);
            falle2.Subscribe(k2);
            falle3.Subscribe(k1);

            Console.WriteLine("Alle haben abonniert!");
            Console.WriteLine("Falle 2");
            falle2.SchnapptZu();

            Console.WriteLine("\nFalle 3");
            falle3.SchnapptZu();

            Console.WriteLine("\nFalle 1");
            falle1.SchnapptZu();

            Console.WriteLine("\nK1 (Kenny) Deabonniert");
            falle1.Unsubcribe(k1);

            Console.WriteLine("\nFalle 1");
            falle1.SchnapptZu();

            Console.ReadKey(true);
        }
    }
}
