using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        public string Type;
        public DayOfWeek UgeDag = new DayOfWeek();
        public DateTime LocalTid = DateTime.Now;
        public DateTime StartTidspunkt = new DateTime();
        public DateTime SlutTidspunkt = new DateTime();
        public string StartTidspunktString;
        public string SlutTidspunktString;
        public bool ValidDate;
        public bool ValidType;

        Dictionary<string, Kreds> kredser;



        public BadetidsPeriode(string type, DayOfWeek ugeDag, string startTidspunktString, string slutTidspunktString)
        {
            kredser = new Dictionary<string, Kreds>();
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
        public BadetidsPeriode()
        {

        }

        DateTime startTidspunkt
        {
            get { return StartTidspunkt; }
        }


        public virtual void AddKreds(Kreds kreds)
        {
            kredser.Add(kreds.ID,kreds);
        }

        public virtual void DeleteKreds(string ID)
        {
            kredser.Remove(ID);
        }

        public string PeriodeLængde()
        {
            System.TimeSpan result = SlutTidspunkt.Subtract(StartTidspunkt);
            int Hours = result.Hours;
            int Mins = result.Minutes;
            return "Varihed: " + Hours + "timer og " + Mins + "minutter";
        }

        public string TidTilBadeTid()
        {
            System.TimeSpan result = StartTidspunkt.Subtract(LocalTid);
            int Days = result.Days;
            int Hours = result.Hours;
            int Mins = result.Minutes;
            return "Tid til BadePeriode: " + Days + " dage, " + Hours + " timer og " + Mins + " minutter. ";
        }

        public override string ToString()
        {
            if (ValidDate == true && ValidType == true)
            {
                string periode = PeriodeLængde();
                string tid = TidTilBadeTid();
                Console.WriteLine($"{Type}: {UgeDag}, {StartTidspunkt} til {SlutTidspunkt}");
                Console.Write(tid);
                Console.WriteLine(periode);
                Console.WriteLine($"Her er alle Kredser der er tilføjet til {Type}\n");
                foreach (var kreds in kredser)
                {
                    Console.WriteLine(kreds + "\n");
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
