using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSH2_Tag_08_DummeObserverAufgabe
{
    abstract class Subject
    {
        static List<Beobachter> alleBeobachter = new List<Beobachter>();
        public void Benachrichtige()
        {
            foreach (Beobachter b in alleBeobachter)
                b.Update(this);
        }

        public void Subscribe(Beobachter beobachter)
        {
            if (!alleBeobachter.Contains(beobachter))
                alleBeobachter.Add(beobachter);
        }
        public void Unsubcribe(Beobachter beobachter)
        {
            if (alleBeobachter.Contains(beobachter))
                alleBeobachter.Remove(beobachter);
        }
    }
}
