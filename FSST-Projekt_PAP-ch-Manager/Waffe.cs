using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSST_Projekt_PAP_ch_Manager
{
    public class Waffe
    {
        #region Variablen

        private int SCHADEN, PREIS;
        private string NAME, MATERIAL;
        private int REICHWEITE;
        #endregion

        #region Konstruktor
        public Waffe() { }

        public Waffe(string name, int schaden, int reichweite, string material, int preis)
        {
            NAME=name;
            SCHADEN=schaden;
            REICHWEITE=reichweite;
            MATERIAL=material;
            PREIS=preis;
        }
        #endregion

        #region ändern

        public void change_Name(string newName) { NAME=newName; }
        public void change_Schaden(int newSchaden) { SCHADEN = newSchaden; }
        public void change_Preis(int newPreis) { PREIS = newPreis; }
        public void change_Material(string newMaterial) { MATERIAL = newMaterial; }
        public void change_Reichweite(int newReichweite) { REICHWEITE = newReichweite;}

        #endregion

        #region Ausgaben
        public string get_Name { get { return NAME; } }
        public int get_Schaden { get { return SCHADEN; } }
        public int get_Preis { get { return PREIS; } }
        public int get_Reichweite { get { return REICHWEITE; } }
        public string get_Material { get { return MATERIAL; } }
        #endregion

        #region hilfsfunktion
        public override string ToString()
        {
            string s = "";
            s += NAME +","+ SCHADEN +","+ REICHWEITE +","+ MATERIAL +","+ PREIS;
            return s;
        }

        public string ausgeben()
        {
            string s = "";
            s += "Name: " + NAME + "\tSchaden: " + SCHADEN + "\tReichweite: " + REICHWEITE + "\tMaterial: " + MATERIAL + "\tPreis: " + PREIS;
            return s;
        }
        #endregion

    }
}
