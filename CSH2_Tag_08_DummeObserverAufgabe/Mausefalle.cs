using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_08_DummeObserverAufgabe
{
    class Mausefalle : Subject
    {
        string standort;

        public Mausefalle(string standort)
        {
            this.standort = standort;
        }

        public string Standort { get => standort; set => standort = value; }

        public void SchnapptZu()
        {
            Benachrichtige();
        }
    }
}
