using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        public string ID;
        public string Navn;
        public string Adresse;
        public int AntalDeltagere = 0;

        public Kreds(string iD, string navn, string adresse, int antalDeltagere)
        {
            ID = iD;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }

        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }


        public override string ToString()
        {
            return "\nID: " + ID + "\nNavn: " + Navn + "\nAdresse: " + Adresse + "\nAntal Deltagere: " + AntalDeltagere;
        }











    }
}
