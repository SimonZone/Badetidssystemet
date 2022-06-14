using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        List<Kreds> _KredseList;

        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, string startTidspunktString, string slutTidspunktString)
        {
            _KredseList = new List<Kreds>();
            Type = type;
            UgeDag = ugeDag;
            StartTidspunktString = startTidspunktString;
            SlutTidspunktString = slutTidspunktString;
        }

        public override void AddKreds(Kreds kreds)
        {
            _KredseList.Add(kreds);
        }

        public override void DeleteKreds(string ID)
        {
            //List offset
            int IDint = Convert.ToInt32(ID) - 1;
            _KredseList.RemoveAt(IDint);
        }
        public override string ToString()
        {
            if (true)
            {
                string periode = PeriodeLængde();
                string tid = TidTilBadeTid();
                Console.WriteLine($"{Type}: {UgeDag}, {StartTidspunkt} til {SlutTidspunkt}");
                Console.Write(tid);
                Console.WriteLine(periode);
                Console.WriteLine($"Her er alle Kredser der er tilføjet til {Type}\n");
                for (int i = 0; i < _KredseList.Count; i++)
                {
                    Console.WriteLine(_KredseList.ToString());
                }
            }
            else
            {
                Console.WriteLine("Datoerne og tid eller Type er ikke godkendt");
            }

            return "";
        }
    }
}
