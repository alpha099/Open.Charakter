using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSST_Projekt_PAP_ch_Manager
{
    public class Gegenstand
    {
        #region Werte
        private string NAME, SPEZIFIKATIONEN;
        private int GEWICHT, PREIS;
        #endregion

        #region Konstruktor
        public Gegenstand() { }
        public Gegenstand(string Name) { NAME = Name; }
        public Gegenstand(string Name, int Gewicht) { NAME = Name; GEWICHT = Gewicht; }
        public Gegenstand(string Name, int Gewicht, string Spezifikationen) { NAME = Name; GEWICHT = Gewicht;SPEZIFIKATIONEN = Spezifikationen; }
        public Gegenstand(string Name, int Gewicht, string Spezifikationen, int Preis) { NAME = Name; GEWICHT = Gewicht;SPEZIFIKATIONEN=Spezifikationen; PREIS = Preis; }
        #endregion


        #region Werte ändern

        public void change_Name(string NewName) { NAME = NewName; }
        public void change_Gewicht(int NewGewicht) {GEWICHT = NewGewicht; }
        public void change_Spezifikation(string NewSpezifikationen) { SPEZIFIKATIONEN = NewSpezifikationen; }
        public void change_Preis(int NewPreis) { PREIS = NewPreis; }

        #endregion

        #region Werte Ausgeben

        public string name { get { return NAME; } }
        public int gewicht { get { return GEWICHT; } }
        public string spezifikationen { get { return SPEZIFIKATIONEN; } }
        public int preis { get { return PREIS; } }

        #endregion

        #region hilfsfunktion

        public override string ToString()
        {
            string s="";
            s += NAME + "," + GEWICHT + "," + SPEZIFIKATIONEN + "," + PREIS;
            return s;
        }

        public string ausgeben()
        {
            string s = "";
            s += NAME + ",\t" + GEWICHT + ",\t" + SPEZIFIKATIONEN + ",\t" + PREIS;
            return s;
        }

        #endregion

    }
}
