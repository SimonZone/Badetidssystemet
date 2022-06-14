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

            #region Validering af StartTidspunkt og SlutTidspunkt
            DateTime dateTime1 = DateTime.Parse(StartTidspunktString);
            DateTime dateTime2 = DateTime.Parse(SlutTidspunktString);
            int diff = DateTime.Compare(dateTime2, dateTime1);
            if (diff == -1)
            {
                ValidDate = false;
            }
            else
            {
                ValidDate = true;
                StartTidspunkt = dateTime1;
                SlutTidspunkt = dateTime2;
            }
            #endregion

            #region Validering af Type på mindst 4 tegn
            int StringLength = Type.Length;
            if (StringLength >= 4)
            {
                ValidType = true;
            }
            else
            {
                ValidType = false;
            }
            #endregion
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
                    Console.WriteLine(_KredseList[i].ToString());
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
