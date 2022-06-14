using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        public string Type = "";
        public DayOfWeek UgeDag = new DayOfWeek();
        public DateTime StartTidspunkt = new DateTime();
        public DateTime SlutTidspunkt = new DateTime();
        public string StartTidspunktString = "";
        public string SlutTidspunktString = "";

        Dictionary<string, Kreds> kredser;



        public BadetidsPeriode(string type, DayOfWeek ugeDag, string startTidspunktString, string slutTidspunktString)
        {
            kredser = new Dictionary<string, Kreds>();
            Type = type;
            UgeDag = ugeDag;
            StartTidspunktString = startTidspunktString;
            SlutTidspunktString = slutTidspunktString;

            try
            {
                DateTime dateTime1 = DateTime.Parse(startTidspunktString);
                DateTime dateTime2 = DateTime.Parse(slutTidspunktString);
                //int diff = DateTime.Compare(dateTime2, dateTime1);
                StartTidspunkt = dateTime1;
                SlutTidspunkt = dateTime2;
            }
            catch (Exception)
            {

            }
        }



        public void AddKreds(Kreds kreds)
        {
            kredser.Add(kreds.ID,kreds);
        }

        public void DeleteKreds(string ID)
        {
            kredser.Remove(ID);
        }

        public override string ToString()
        {
            Console.WriteLine($"Her er alle Kredser der er tilføjet til {Type}\n");
            foreach (var kreds in kredser)
            {
                Console.WriteLine(kreds + "\n");
            }
            return "";
        }










    }
}
