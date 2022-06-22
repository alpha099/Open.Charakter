using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSST_Projekt_PAP_ch_Manager
{
    public class Fertigkeiten
    {
        #region Variablen
        private string NAME;
        private int BONUS;
        private int Leitfertigkeit;
        #endregion

        #region Konstruktor
        public Fertigkeiten() { }
        public Fertigkeiten(string name, int bonus)
        {
            NAME = name;
            BONUS = bonus;
        }
        public Fertigkeiten(string name, int bonus, int leitfertigkeit) 
        { 
            NAME = name; 
            BONUS = bonus;
            Leitfertigkeit = Werte_Bonus(leitfertigkeit);
        }
        #endregion

        #region Change werte

        public void change_name(string name)
        {
            NAME = name;
        }
        public void change_bonus(int newbonus) 
        { 
            BONUS = newbonus; 
        }

        public void change_extra(int leitfertigkeit)
        {
            Leitfertigkeit = Werte_Bonus(leitfertigkeit);
        }

        #endregion

        #region Ausgaben
        public int bonus { get { return BONUS; } }
        public string name { get { return NAME; } }
        public int extrabonus { get { return Leitfertigkeit; } }
        #endregion

        #region hilfsfunktionen
        private int Werte_Bonus(int WertName)
        {
            if (WertName == null) return 0;
            if (WertName < 5) return -2;
            if (WertName < 20 && WertName > 5) return -1;
            if (WertName < 81 && WertName > 20) return 0;
            if (WertName < 95 && WertName > 81) return +1;
            if (WertName < 101) return +2;

            if (WertName < 1 || WertName > 100)
            {
                return 0;
                throw new Exception("Falscher Wert, Wert ausserhalb des angegebenen Bereichs");
            }
            return 0;
        }
        public override string ToString()
        {
            string s = "";
            s += name +","+ bonus +","+ extrabonus;
            return s;
        }

        public string ausgeben()
        {
            string s = "";
            s += name + ",\t" + bonus + ",\t" + extrabonus;
            return s;
        }
        #endregion
    }
}
