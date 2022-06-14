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
        public bool ValidDeltagere;

        public Kreds(string iD, string navn, string adresse, int antalDeltagere)
        {
            ID = iD;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;

            #region Validering af AntalDeltagere

            if (AntalDeltagere <= 0)
            {
                ValidDeltagere = false;
            }
            else
            {
                ValidDeltagere = true;
            }
            #endregion
        }

        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }


        public override string ToString()
        {
            if (ValidDeltagere == true)
            {
                return "\nID: " + ID + "\nNavn: " + Navn + "\nAdresse: " + Adresse + "\nAntal Deltagere: " + AntalDeltagere;
            }
            return "Der er ikke nok Deltagere, der skal være mere end 0";
        }











    }
}
