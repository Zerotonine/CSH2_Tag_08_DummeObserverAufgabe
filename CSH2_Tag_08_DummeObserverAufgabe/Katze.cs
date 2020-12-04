using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_08_DummeObserverAufgabe
{
    class Katze : Beobachter
    {
        private string name;

        public Katze(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public void Update(object obj)
        {
            if(obj is Mausefalle)
                Console.WriteLine($"Katze {name}:\tFalle {(obj as Mausefalle).Standort} hat zugeschnappt!");
        }
    }
}
