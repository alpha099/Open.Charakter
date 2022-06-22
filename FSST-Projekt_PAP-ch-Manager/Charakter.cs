using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using Microsoft.Windows;

namespace FSST_Projekt_PAP_ch_Manager
{
    public class Charakter
    {

        #region Variablen
        private int ST, GS, GW, KO, IN, ZT, AU, PA, WK, BW;         //Haupteigenschaften
        private int RAUFEN, AUSDAUERBONUS, SCHADENSBONUS, ANGRIFFSBONUS, ABWEHRBONUS, RESISTENZBONUS_KÖRPER, RESISTENZBONUS_GEIST, ZAUBERBONUS, WAHRNEHMUNG, TRINKEN;     //sekundäre eigenschaften
        private int LPMAX, APMAX, GG, SG, GROESSE, GEWICHT, GRAD, ALTER;                           //tertiäre eigenschaften

        private string HAND, GESTALT, STAND, HEIMAT, GLAUBE, MERKMALE, NAME, RASSE;     //Merkmale
        private string BERUF, SPETZIALISIERUNG;
        private int EP, ES;
        private double GELD;
        #endregion

        #region Listen
        List<Fertigkeiten> Fertigkeitenlist = new List<Fertigkeiten>();
        List<Waffe> Waffenlist = new List<Waffe>();
        List<Gegenstand> Inventarliste = new List<Gegenstand>();
        #endregion


        #region Konstruktoren
        public Charakter(bool random) 
        {
            if (random) 
            {
                calc_all_stats();
                
            }
            ini_fertigkeiten(); 
        }                      //Konstruktor für Charakter ohne existierende Werte
        public Charakter(int st, int gs, int gw, int ko, int intell, int zt)
        {
            ST = st;
            GS = gs;
            GW = gw;
            KO = ko;
            IN = intell;
            ZT = zt;
            PA = calc_PA(IN);
            WK = calc_WK(KO, IN);
            AU = r.Next(1, 100);
            calc_stats();
            ini_fertigkeiten();
        }
        public Charakter(int st, int gs, int gw, int ko, int intell, int zt, int PA, int WK, int AU)
        {
            calc_stats();
            ini_fertigkeiten();
        }

        
        #endregion


        #region Ausgaben

        #region Werte Charakter
        public int St { get { return ST; } }
        public int Gs { get { return GS; } }
        public int Gw { get { return GW; } }
        public int Ko { get { return KO; } }
        public int In { get { return IN; } }
        public int Zt { get { return ZT; } }
        public int Au { get { return AU; } }
        public int Pa { get { return PA; } }
        public int Wk { get { return WK; } }
        public int B { get { return BW; } }
        public int Raufen { get { return RAUFEN; } }
        public int Ausdauerbonus { get { return AUSDAUERBONUS; } }
        public int Schadensbonus { get { return SCHADENSBONUS; } }
        public int Angriffsbonus { get { return ANGRIFFSBONUS; } }
        public int Abwehrbonus { get { return ABWEHRBONUS; } }
        public int Resistenzbonus_Körper { get { return RESISTENZBONUS_KÖRPER; } }
        public int Resistenzbonus_Geist { get { return RESISTENZBONUS_GEIST; } }
        public int Zauberbonus { get { return ZAUBERBONUS; } }
        public int Wahrnehmung { get { return WAHRNEHMUNG; } }
        public int Trinken { get { return TRINKEN; } }
        public int LP { get { return LPMAX; } }
        public int AP { get { return APMAX; } }

        #endregion

        #region Werte Person und Körper
        public string Hand { get { return HAND; } }
        public int Groesse { get { return GROESSE; } }
        public int Gewicht { get { return GEWICHT; } }
        public int Grad { get { return GRAD; } }
        public int Alter { get { return ALTER; } }

        public string Gestalt { get { return GESTALT; } }
        public string Stand { get { return STAND; } }
        public string Heimat { get { return HEIMAT; } }
        public string Glaube { get { return GLAUBE; } }
        public string Merkmale { get { return MERKMALE; } }
        public string Name { get { return NAME; } }
        public string Rasse { get { return RASSE; } }
        public string Beruf { get { return BERUF; } }
        public string Spetzialisierung { get { return SPETZIALISIERUNG; } }


        #endregion

        #region Geld und EP und GG

        public int Gg { get { return GG; } }
        public int Sg { get { return SG; } }
        public int Ep { get { return EP; } }
        public int Es { get { return ES; } }
        public double Geld { get { return GELD; } }

        #endregion

        #region Übruge listen

        public string fähigkeiten()
        {
            string s="";

            foreach (Fertigkeiten fer in Fertigkeitenlist)
            {
                s += fer.ausgeben() + "\n";
            }
            return s;
        }

        public string waffen()
        {
            string s = "";

            foreach (Waffe fer in Waffenlist)
            {
                s += fer.ausgeben() + "\n";
            }
            return s;
        }

        public string Inventar()
        {
            string s = "";
            foreach (Gegenstand gegenstand in Inventarliste)
            {
                s += gegenstand.ausgeben() + "\n";

            }
            return s;
        }
        #endregion

        #endregion


        #region Werte

        public void add_stats(int st, int gs, int gw, int ko, int inte, int zt, int au, int pa, int wk, int bw, int raufen, int ausb, int schadb, int angb, int abwb, int resk, int resg, int zaub, int wahrn, int trink, int lpmax, int apmax, int gg, int sg, int groess, int gewicht, int grad, int alter, string hand, string gestalt, string stand, string heimat, string glaube, string merkmale, string name, string rasse, string beruf, string spetzialisierung, int ep, int es, double geld)
        {
            ST = st;
            GS = gs;
            GW = gw;
            KO = ko;
            IN = inte;
            ZT= zt;
            AU = au;
            PA = pa;
            WK = wk;
            BW = bw;
            RAUFEN = raufen;
            AUSDAUERBONUS = ausb;
            SCHADENSBONUS = schadb;
            ANGRIFFSBONUS = angb;
            ABWEHRBONUS = abwb;
            RESISTENZBONUS_KÖRPER = resk;
            RESISTENZBONUS_GEIST = resg;
            ZAUBERBONUS = zaub;
            WAHRNEHMUNG = wahrn;
            TRINKEN = trink;
            LPMAX = lpmax;
            APMAX=apmax;
            GG = gg;
            SG = sg;
            GROESSE = groess;
            GEWICHT = gewicht;
            GRAD = grad;
            ALTER = alter;
            HAND = hand;
            GESTALT = gestalt;
            STAND = stand;
            HEIMAT = heimat;
            GLAUBE = glaube;
            MERKMALE = merkmale;
            NAME = name;
            RASSE = rasse;
            BERUF = beruf;
            SPETZIALISIERUNG = spetzialisierung;
            EP = ep;
            ES = es;
            GELD = geld;

        }
        public void add_stats_w_random(int st, int gs, int gw, int ko, int intell, int zt)
        {
            ST = st;
            GS = gs;
            GW = gw;
            KO = ko;
            IN = intell;
            ZT = zt;
            PA = calc_PA(IN);
            WK = calc_WK(KO, IN);
            AU = r.Next(1, 100);
            calc_stats();
        }
        public void add_besondere_Fähigkeit(int W100wurf)
        {
            if (W100wurf >= 1 || W100wurf <= 100)
            {
                if (W100wurf < 6) change_bonus(-2, "Sehen");
                if (W100wurf > 5 && W100wurf < 11) change_bonus(-2, "Höhren");
                if (W100wurf > 10 && W100wurf < 16) change_bonus(-2, "Riechen");
                if (W100wurf > 15 && W100wurf < 21) change_bonus(+2, "Sechster Sinn");
                if (W100wurf > 20 && W100wurf < 31) change_bonus(+2, "Sehen");
                if (W100wurf > 30 && W100wurf < 41) change_bonus(+2, "Höhren");
                if (W100wurf > 40 && W100wurf < 51) change_bonus(+2, "Riechen");
                if (W100wurf > 50 && W100wurf < 56) change_bonus(+2, "Nachtsicht");
                if (W100wurf > 55 && W100wurf < 61) Fertigkeitenlist.Add(new Fertigkeiten("Gute Reflexe", +9));
                if (W100wurf > 60 && W100wurf < 66) Fertigkeitenlist.Add(new Fertigkeiten("Richtungssinn", +12));
                if (W100wurf > 65 && W100wurf < 71) Fertigkeitenlist.Add(new Fertigkeiten("Robustheit", +9));
                if (W100wurf > 70 && W100wurf < 76) Fertigkeitenlist.Add(new Fertigkeiten("Schmerzunempfindlichkeit", +9));
                if (W100wurf > 75 && W100wurf < 81) TRINKEN = +12;
                if (W100wurf > 80 && W100wurf < 86) Fertigkeitenlist.Add(new Fertigkeiten("Wachgabe", +6));
                if (W100wurf > 85 && W100wurf < 91) WAHRNEHMUNG = 8;
                if (W100wurf > 90 && W100wurf < 96) Fertigkeitenlist.Add(new Fertigkeiten("Einprägen", +4));
                if (W100wurf > 95 && W100wurf < 100) Fertigkeitenlist.Add(new Fertigkeiten("Berserkergang", (18 - WK / 5)));
                if (W100wurf == 100) Fertigkeitenlist.Add(new Fertigkeiten("Eine andere Fähigkeit auswählen", +01));
            }
            else
            {
                throw new Exception("Falscher Wert, Wert ausserhalb des angegebenen Bereichs");
            }
        }
        public void add_besondere_Fähigkeit()
        {
            int W100wurf = r.Next(1, 100);
            do
            {
                if (W100wurf < 6) change_bonus(-2, "Sehen");
                if (W100wurf > 5 && W100wurf < 11) change_bonus(-2, "Höhren");
                if (W100wurf > 10 && W100wurf < 16) change_bonus(-2, "Riechen");
                if (W100wurf > 15 && W100wurf < 21) change_bonus(+2, "Sechster Sinn");
                if (W100wurf > 20 && W100wurf < 31) change_bonus(+2, "Sehen");
                if (W100wurf > 30 && W100wurf < 41) change_bonus(+2, "Höhren");
                if (W100wurf > 40 && W100wurf < 51) change_bonus(+2, "Riechen");
                if (W100wurf > 50 && W100wurf < 56) change_bonus(+2, "Nachtsicht");
                if (W100wurf > 55 && W100wurf < 61) Fertigkeitenlist.Add(new Fertigkeiten("Gute Reflexe", +9));
                if (W100wurf > 60 && W100wurf < 66) Fertigkeitenlist.Add(new Fertigkeiten("Richtungssinn", +12));
                if (W100wurf > 65 && W100wurf < 71) Fertigkeitenlist.Add(new Fertigkeiten("Robustheit", +9));
                if (W100wurf > 70 && W100wurf < 76) Fertigkeitenlist.Add(new Fertigkeiten("Schmerzunempfindlichkeit", +9));
                if (W100wurf > 75 && W100wurf < 81) TRINKEN = +12;
                if (W100wurf > 80 && W100wurf < 86) Fertigkeitenlist.Add(new Fertigkeiten("Wachgabe", +6));
                if (W100wurf > 85 && W100wurf < 91) WAHRNEHMUNG = 8;
                if (W100wurf > 90 && W100wurf < 96) Fertigkeitenlist.Add(new Fertigkeiten("Einprägen", +4));
                if (W100wurf > 95 && W100wurf < 100) Fertigkeitenlist.Add(new Fertigkeiten("Berserkergang", (18 - WK / 5)));
                if (W100wurf == 100) Fertigkeitenlist.Add(new Fertigkeiten("Eine andere Fähigkeit auswählen", +01));
            }
            while (W100wurf != 100);
        }
        #endregion

        #region Fertigkeiten
        public void ini_fertigkeiten()
        {
            Fertigkeitenlist.Add(new Fertigkeiten("Sehen", 0));
            Fertigkeitenlist.Add(new Fertigkeiten("Nachtsicht", 0));
            Fertigkeitenlist.Add(new Fertigkeiten("Höhren", 0));
            Fertigkeitenlist.Add(new Fertigkeiten("Riechen", 0));
            Fertigkeitenlist.Add(new Fertigkeiten("Sechster Sinn", 0));
        }
        public void add_fertigkeit(string fertigkeitenname, int fertigkeitenbonus) { Fertigkeitenlist.Add(new Fertigkeiten(fertigkeitenname, fertigkeitenbonus)); }
       
        public void add_fertigkeit(Fertigkeiten fer)
        {
            Fertigkeitenlist.Add(fer);
        }
        public void remove_fertigkeit(string fertigkeit)
        {
            foreach (Fertigkeiten fer in Fertigkeitenlist)
            {
                if (fer.name == fertigkeit)
                {
                    Fertigkeitenlist.Remove(fer);
                }
            }
        }
        #endregion

        #region Inventar

        public void add_Gegenstand(string gegenstandname) { Inventarliste.Add(new Gegenstand(gegenstandname)); }
        public void add_Gegenstand(string gegenstandname, int gegenstandgewicht) { Inventarliste.Add(new Gegenstand(gegenstandname, gegenstandgewicht)); }
        public void add_Gegenstand(string gegenstandname, int gegenstandgewicht, string spezifikation) { Inventarliste.Add(new Gegenstand(gegenstandname, gegenstandgewicht, spezifikation)); }
        public void add_Gegenstand(string gegenstandname, int gegenstandgewicht, string spezifikation, int preis) { Inventarliste.Add(new Gegenstand(gegenstandname, gegenstandgewicht, spezifikation, preis)); }

        public void remove_Gegenstand(string gegenstandname)
        {
            foreach (Gegenstand ger in Inventarliste)
            {
                if (ger.name == gegenstandname)
                {
                    Inventarliste.Remove(ger);
                }
            }
        }

        public void change_Gegenstandname(string gegenstandname, string newname)
        {
            foreach (Gegenstand ger in Inventarliste)
            {
                if (ger.name == gegenstandname)
                {
                    ger.change_Name(newname);
                }
            }
        }
        public void change_Gegenstandgewicht(string gegenstandname, int newgewicht)
        {
            foreach (Gegenstand ger in Inventarliste)
            {
                if (ger.name == gegenstandname)
                {
                    ger.change_Gewicht(newgewicht);
                }
            }
        }
        public void change_Gegendstandspezifikation(string gegenstandname, string newspezifikation)
        {
            foreach (Gegenstand ger in Inventarliste)
            {
                if (ger.name == gegenstandname)
                {
                    ger.change_Spezifikation(newspezifikation);
                }
            }
        }
        public void change_Gegenstandpreis(string gegenstandname, int newpreis)
        {
            foreach (Gegenstand ger in Inventarliste)
            {
                if (ger.name == gegenstandname)
                {
                    ger.change_Preis(newpreis);
                }
            }
        }
    
        #endregion

        #region Bonus
        public void change_bonus(int fertigkeitenbonus, string fertigkeiten )
        {
            foreach (Fertigkeiten fer in Fertigkeitenlist)
            {
                if (fer.name == fertigkeiten)
                {
                    fer.change_bonus(fertigkeitenbonus);
                }
            }
        }
        #endregion

        #region Waffen
        public void add_waffe(string name, int schaden, int reichweite, string material, int preis) {Waffenlist.Add(new Waffe(name, schaden, reichweite, material, preis)); }
        #endregion

        #region GG
        public void add_GG(int anz)
        {
            GG+=anz;
        }
        public void remove_GG(int anz)
        {
            GG -= anz;
        }
        #endregion

        #region SG
        public void add_SG(int anz)
        {
            SG += anz;
        }
        public void remove_SG(int anz)
        {
            SG -= anz;
        }
        #endregion

        #region Erfahrung
        public void add_EP(int anz)
        {
            EP += anz;
        }
        public void pay_EP(int anz)
        {
            EP -= anz;
            ES += anz;
        }
        public void remove_EP(int anz)
        {
            EP-=anz;
        }
        public void remove_ES(int anz) 
        { 
            ES -= anz;
        }
        #endregion

        #region Geld
        public void add_geld(double anz)
        {
            GELD += anz;
        }
        public void remove_geld(double anz)
        {
            GELD -= anz;
        }
        #endregion

        #region Person

        #region Grad
        public void add_grad(int anz)
        {
            GRAD += anz;
        }
        #endregion

        #region Spezialisierung
        public void add_spetzialisierung(string spetzialisierung)
        {
            SPETZIALISIERUNG = spetzialisierung;
        }
        #endregion

        #region Beruf
        public void add_beruf(string beruf)
        {
            BERUF=beruf;
        }
        #endregion

        #region Rasse
        public void add_rasse(string rasse)
        {
            RASSE = rasse;
        }
        #endregion

        #region Merkmale
        public void add_merkmale(string merkmale)
        {
            MERKMALE=merkmale;
        }
        #endregion

        #region Glaube
        public void add_glaube(string glaube)
        {
            GLAUBE=glaube;  
        }
        #endregion

        #region Heimat
        public void add_heimat(string heimat)
        {
            HEIMAT=heimat;
        }
        #endregion

        #region Stand
        public void add_stand()
        {
            int hilfe = r.Next(1, 100);
            if (hilfe < 10) STAND = "Unfrei";
            if (hilfe <= 50 && hilfe >= 11) STAND = "Volk";
            if (hilfe <= 90 && hilfe >= 51) STAND = "Mittelschicht";
            if (hilfe > 90) STAND = "Adel";
        }
        public void add_stand(string Stand)
        {
            STAND = Stand;
        }
        #endregion

        #endregion

        #region Körper

        #region Gestalt
        public void add_Gestallt(string Gestalt)
        {
            GESTALT = Gestalt;
        }
        #endregion

        #region Größe
        public void add_groesse(int height)
        {
            GROESSE=height;
        }
        public void add_groesse()
        {
            int hilfe1 = r.Next(1, 20);
            int hilfe2 = r.Next(1, 20);
            GROESSE=(hilfe1+hilfe2)+(ST/10)+145;
        }
        #endregion

        #region Alter
        public void add_Alter(int age)
        {
            ALTER = age;
        }
        public void add_Alter()
        {
            ALTER = r.Next(15, 150);
        }
        #endregion

        #region Hand
        public void random_HAND()
        {
            int hilfe = r.Next(1, 20);
            if (hilfe == 20) HAND = "Beidhänder";
            if (hilfe >= 19 && hilfe <= 16) HAND = "Linkshänder";
            if (hilfe <= 15 && hilfe >= 1) HAND = "Rechtshänder";
        }
        public void Haendigkeit(string hand)
        {
            HAND = hand;
        }
        #endregion

        #endregion


        #region Hilfsfunktionen
        Random r = new Random();
        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        StreamWriter sw;
        StreamReader sr;

        private int Werte_Bonus(int WertName)
        {
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
        private int calc_PA(int INT)
        {
            return (r.Next(1, 100) + (4 * INT / 10) - 20);
        }
        private int calc_WK(int KON, int INT)
        {
            return (r.Next(1, 100) + 2 * (KON / 10 + INT / 10) - 20);
        }
        private void calc_stats()
        {
            AUSDAUERBONUS = KO / 10 + ST / 20;
            LPMAX = r.Next(1, 3) + 7 + KO / 10;
            APMAX = r.Next(1, 3) + 1 + AUSDAUERBONUS;
            SCHADENSBONUS = ST / 20 + GS / 30 - 3;
            BW = (r.Next(1, 3) + r.Next(1, 3) + r.Next(1, 3) + r.Next(1, 3)) + 16;
            RESISTENZBONUS_GEIST = Werte_Bonus(IN);
            RESISTENZBONUS_KÖRPER = Werte_Bonus(KO);
            ANGRIFFSBONUS = Werte_Bonus(GS);
            ABWEHRBONUS = Werte_Bonus(GW);
            ZAUBERBONUS = Werte_Bonus(ZT);
            RAUFEN = +(ST + GW) / 20 + ANGRIFFSBONUS;
            TRINKEN = +KO / 10;
            WAHRNEHMUNG = 6;
        }
        private void calc_all_stats()
        {
            ST = r.Next(1, 100);
            GS= r.Next(1, 100);
            GW= r.Next(1, 100);
            ZT= r.Next(1, 100);
            KO= r.Next(1, 100);
            IN= r.Next(1, 100);
            PA = calc_PA(IN);
            WK = calc_WK(KO, IN);
            AU = r.Next(1, 100);
            calc_stats();
        }
        private string ausgabe_Werte
        {
            get
            {
                string s = "";
                s += ST + "," + GS + "," + GW + "," + KO + "," + IN + "," + ZT + "," + AU + "," + PA + "," + WK + "," + BW + "," + RAUFEN + "," + AUSDAUERBONUS + "," +
                    SCHADENSBONUS + "," + ANGRIFFSBONUS + "," + ABWEHRBONUS + "," + RESISTENZBONUS_KÖRPER + "," + RESISTENZBONUS_GEIST + "," + ZAUBERBONUS + "," +
                    WAHRNEHMUNG + "," + TRINKEN + "," + LPMAX + "," + APMAX + "," + GG + "," + SG + "," + GROESSE + "," + GEWICHT + "," + GRAD + "," + ALTER + "," + HAND + "," +
                    GESTALT + "," + STAND + "," + HEIMAT + "," + GLAUBE + "," + MERKMALE + "," + NAME + "," + RASSE + "," + BERUF + "," + SPETZIALISIERUNG + "," +
                    EP + "," + ES + "," + GELD;
                return s;
            }
        }


        #endregion

        #region Speichern und Öffnen

        #region Speichern

        public void save_Charakter()
        {
            #region Save Charakter
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "Charakter files (*.car)|*.car";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == false)
                return;
            string path = sfd.FileName;

            
            sw = new StreamWriter(path);
            string s = "";
            s = ausgabe_Werte;

            sw.Write(s);
            #endregion

            #region save Weapons

            sw.Flush();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "Weapon files (*.weap)|*.weap";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == false)
                return;
            path = sfd.FileName;

            sw = new StreamWriter(path);
            s = "";
            foreach (Waffe w in Waffenlist)
            {
                s += w.ToString() + "\n";
            }
            sw.Write(s);

            #endregion

            #region Save Fertigkeiten

            sw.Flush();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "skill files (*.skl)|*.skl";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == false)
                return;
            path = sfd.FileName;

            sw = new StreamWriter(path);
            s = "";
            foreach (Fertigkeiten fer in Fertigkeitenlist)
            {
                s += fer.ToString() + "\n";
            }
            sw.Write(s);

            #endregion

            #region Save Inventar

            sw.Flush();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "Inventory files (*.inv)|*.inv";
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == false)
                return;
            path = sfd.FileName;

            sw = new StreamWriter(path);
            s = "";
            foreach (Gegenstand ger in Inventarliste)
            {
                s += ger.ToString() + "\n";
            }
            sw.Write(s);

            #endregion

            sw.Close();
        }
        #endregion

        #region öffnen
        public void open_Charakter()
        {
            #region Open Charakter

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Charakter files (*.car)|*.car";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == false)
                return;                         //Abbruch
            string path = ofd.FileName;

            sr = new StreamReader(path);
            string s;
            char[] sep = { ',' };
            string[] sa = new string[42];
            while((s = sr.ReadLine()) != null)
            {
                sa = s.Split(sep);
                ST = Convert.ToInt32(sa[0]);
                GS = Convert.ToInt32(sa[1]);
                GW= Convert.ToInt32(sa[2]);
                KO = Convert.ToInt32(sa[3]);
                IN= Convert.ToInt32(sa[4]);
                ZT = Convert.ToInt32(sa[5]);
                AU= Convert.ToInt32(sa[6]);
                PA= Convert.ToInt32(sa[7]);
                WK= Convert.ToInt32(sa[8]);
                BW = Convert.ToInt32(sa[9]);
                RAUFEN = Convert.ToInt32(sa[10]);
                AUSDAUERBONUS= Convert.ToInt32(sa[11]);
                SCHADENSBONUS= Convert.ToInt32(sa[12]);
                ANGRIFFSBONUS= Convert.ToInt32(sa[13]);
                ABWEHRBONUS= Convert.ToInt32(sa[14]);
                RESISTENZBONUS_KÖRPER= Convert.ToInt32(sa[15]);
                RESISTENZBONUS_GEIST= Convert.ToInt32(sa[16]);
                ZAUBERBONUS= Convert.ToInt32(sa[17]);
                WAHRNEHMUNG= Convert.ToInt32(sa[18]);
                TRINKEN= Convert.ToInt32(sa[19]);
                LPMAX= Convert.ToInt32(sa[20]);
                APMAX= Convert.ToInt32(sa[21]);
                GG= Convert.ToInt32(sa[22]);
                SG= Convert.ToInt32(sa[23]);
                GROESSE= Convert.ToInt32(sa[24]);
                GEWICHT= Convert.ToInt32(sa[25]);
                GRAD= Convert.ToInt32(sa[26]);
                ALTER= Convert.ToInt32(sa[27]);
                HAND = sa[28];
                GESTALT = sa[29];
                STAND = sa[30];
                HEIMAT = sa[31];
                GLAUBE = sa[32];
                MERKMALE = sa[33];
                NAME = sa[34];
                RASSE = sa[35];
                BERUF = sa[36];
                SPETZIALISIERUNG = sa[37];
                EP = Convert.ToInt32(sa[38]);
                ES= Convert.ToInt32(sa[39]);
                GELD = Convert.ToInt32(sa[40]);

            }
            sr.Close();

            #endregion

            #region Open Waffen
            sr.Dispose();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Weapon files (*.weap)|*.weap";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == false)
                return;                         //Abbruch
            path = ofd.FileName;

            sr = new StreamReader(path);
            
            sep[0] = ',';
            sa = new string[5];
            while ((s = sr.ReadLine()) != null)
            {
                Waffenlist.Add(new Waffe(sa[0], Convert.ToInt32(sa[1]), Convert.ToInt32(sa[2]), sa[3], Convert.ToInt32(sa[4])));
            }
            sr.Close();

            #endregion

            #region Open Fertigkeiten

            sr.Dispose();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "skill files (*.skl)|*.skl";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == false)
                return;                         //Abbruch
            path = ofd.FileName;

            sr = new StreamReader(path);

            sep[0] = ',';
            sa = new string[3];
            while ((s = sr.ReadLine()) != null)
            {
                Fertigkeitenlist.Add(new Fertigkeiten(sa[0], Convert.ToInt32(sa[1]), Convert.ToInt32(sa[2])));
            }
            sr.Close();


            #endregion

            #region Open Inventar

            sr.Dispose();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Inventory files (*.inv)|*.inv";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == false)
                return;                         //Abbruch
            path = ofd.FileName;

            sr = new StreamReader(path);

            sep[0] = ',';
            sa = new string[4];
            while ((s = sr.ReadLine()) != null)
            {
                Inventarliste.Add(new Gegenstand(sa[0], Convert.ToInt32(sa[1]), sa[2], Convert.ToInt32(sa[3])));
            }
            sr.Close();

            #endregion

        }


        #endregion

        #endregion

        #region Sonstige Funktionen



        #endregion
    }
}
