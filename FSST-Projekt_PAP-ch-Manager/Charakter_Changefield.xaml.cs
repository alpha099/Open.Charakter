using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FSST_Projekt_PAP_ch_Manager
{
    /// <summary>
    /// Interaktionslogik für Charakter_Changefield.xaml
    /// </summary>
    public partial class Charakter_Changefield : Window
    {
        #region Konstruktoren
        public Charakter_Changefield()
        {
            InitializeComponent();
        }
        Charakter charakter = new Charakter(false);
        public Charakter_Changefield(Charakter charakter1)
        {
            charakter = charakter1;
            InitializeComponent();
            RASSE = "";
            reload_stats();
        }

        #endregion

        #region Variablen
        private int ST, GS, GW, KO, IN, ZT, AU, PA, WK, BW;         //Haupteigenschaften

        private int RAUFEN, AUSDAUERBONUS, SCHADENSBONUS, ANGRIFFSBONUS, ABWEHRBONUS, RESISTENZBONUS_KÖRPER, RESISTENZBONUS_GEIST, ZAUBERBONUS, WAHRNEHMUNG, TRINKEN;     //sekundäre eigenschaften

        

        private int LPMAX, APMAX, GG, SG, GROESSE, GEWICHT, GRAD, ALTER;                           //tertiäre eigenschaften

        private string HAND, GESTALT, STAND, HEIMAT, GLAUBE, MERKMALE, NAME, RASSE;     //Merkmale
        private string BERUF, SPETZIALISIERUNG;
        private int EP, ES;
        private double GELD;
        #endregion

        #region Buttons
        private void BTN_reload_Click(object sender, RoutedEventArgs e)
        {
            reload();
            
        }

        private void BTN_Save_charakter_Click(object sender, RoutedEventArgs e)
        {
            reload();

            charakter.save_Charakter();
        }

        private void BTN_Load_Charakter_Click(object sender, RoutedEventArgs e)
        {
            charakter.open_Charakter();
            reload_stats();
        }

        private void BTN_uebernehmen_Click(object sender, RoutedEventArgs e)
        {
            reload();
            reload_stats();
            this.Exit();
        }

        private void BTN_new_skill_Click(object sender, RoutedEventArgs e)
        {
            neue_Fähigkeit fer = new neue_Fähigkeit(charakter);
            fer.Show();
            reload_stats();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        #endregion

        #region automatisierung

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            reload_stats();
        }

        #endregion

        #region Hilfsfunktionen

        private void Exit()
        {
            this.Close();
        }


        private void reload()
        {
            ST = Convert.ToInt32(TB_ST.Text);
            GS = Convert.ToInt32(TB_GS.Text);
            GW = Convert.ToInt32(TB_GW.Text);
            KO = Convert.ToInt32(TB_KO.Text);
            IN = Convert.ToInt32(TB_IN.Text);
            ZT = Convert.ToInt32(TB_ZT.Text);
            AU = Convert.ToInt32(TB_AU.Text);
            PA = Convert.ToInt32(TB_PA.Text);
            WK = Convert.ToInt32(TB_WK.Text);
            BW = Convert.ToInt32(TB_BW.Text);
            RAUFEN = Convert.ToInt32(TB_RAUFEN.Text);
            AUSDAUERBONUS = Convert.ToInt32(TB_AUSB.Text);
            SCHADENSBONUS = Convert.ToInt32(TB_SCHADB.Text);
            ANGRIFFSBONUS = Convert.ToInt32(TB_ANGB.Text);
            ABWEHRBONUS = Convert.ToInt32(TB_ABWB.Text);
            RESISTENZBONUS_KÖRPER = Convert.ToInt32(TB_RES_K.Text);
            RESISTENZBONUS_GEIST = Convert.ToInt32(TB_RES_G.Text);
            ZAUBERBONUS = Convert.ToInt32(TB_ZAUB.Text);
            LPMAX = Convert.ToInt32(TB_LPM.Text);
            APMAX = Convert.ToInt32(TB_APM.Text);
            GG = Convert.ToInt32(TB_GG.Text);
            SG = Convert.ToInt32(TB_SG.Text);
            GROESSE = Convert.ToInt32(TB_GROESSE.Text);
            GEWICHT = Convert.ToInt32(TB_Gewicht.Text);
            GRAD = Convert.ToInt32(TB_Grad.Text);
            ALTER = Convert.ToInt32(TB_AGE.Text);
            HAND = TB_HAND.Text;
            GESTALT = TB_Gestalt.Text;
            STAND = TB_stand.Text;
            HEIMAT = TB_heimat.Text;
            GLAUBE = TB_glaube.Text;
            MERKMALE = TB_merkmale.Text;
            NAME = TB_charname.Text;
            BERUF = TB_beruf.Text;
            SPETZIALISIERUNG = TB_SPEZIAL.Text;
            EP = Convert.ToInt32(TB_EP.Text);
            ES = Convert.ToInt32(TB_ES.Text);
            GELD = Convert.ToInt32(TB_GELD.Text);

            charakter.add_stats(ST, GS, GW, KO, IN, ZT, AU, PA, WK, BW, RAUFEN, AUSDAUERBONUS, SCHADENSBONUS, ANGRIFFSBONUS, ABWEHRBONUS, RESISTENZBONUS_KÖRPER, RESISTENZBONUS_GEIST, ZAUBERBONUS, WAHRNEHMUNG, TRINKEN, LPMAX, APMAX, GG, SG, GROESSE, GEWICHT, GRAD, ALTER, HAND, GESTALT, STAND, HEIMAT, GLAUBE, MERKMALE, NAME, RASSE, BERUF, SPETZIALISIERUNG, EP, ES, GELD);
            
            reload_stats();
        }

        private void reload_stats()
        {

            TB_ST.Text = Convert.ToString(charakter.St);
            TB_GS.Text = Convert.ToString(charakter.Gs);
            TB_GW.Text = Convert.ToString(charakter.Gw);
            TB_KO.Text = Convert.ToString(charakter.Ko);
            TB_IN.Text = Convert.ToString(charakter.In);
            TB_ZT.Text = Convert.ToString(charakter.Zt);
            TB_AU.Text = Convert.ToString(charakter.Au);
            TB_PA.Text = Convert.ToString(charakter.Pa);
            TB_WK.Text = Convert.ToString(charakter.Wk);
            TB_BW.Text = Convert.ToString(charakter.B);
            TB_RAUFEN.Text = Convert.ToString(charakter.Raufen);
            TB_AUSB.Text = Convert.ToString(charakter.Ausdauerbonus);
            TB_SCHADB.Text = Convert.ToString(charakter.Schadensbonus);
            TB_ANGB.Text = Convert.ToString(charakter.Angriffsbonus);
            TB_ABWB.Text = Convert.ToString(charakter.Abwehrbonus);
            TB_RES_K.Text = Convert.ToString(charakter.Resistenzbonus_Körper);
            TB_RES_G.Text = Convert.ToString(charakter.Resistenzbonus_Geist);
            TB_ZAUB.Text = Convert.ToString(charakter.Zauberbonus);
            TB_LPM.Text = Convert.ToString(charakter.LP);
            TB_APM.Text = Convert.ToString(charakter.AP);
            TB_GG.Text = Convert.ToString(charakter.Gg);
            TB_SG.Text = Convert.ToString(charakter.Sg);
            TB_GROESSE.Text = Convert.ToString(charakter.Groesse);
            TB_Gewicht.Text = Convert.ToString(charakter.Gewicht);
            TB_Grad.Text = Convert.ToString(charakter.Grad);
            TB_AGE.Text = Convert.ToString(charakter.Alter);
            TB_HAND.Text = Convert.ToString(charakter.Hand);
            TB_Gestalt.Text = Convert.ToString(charakter.Gestalt);
            TB_stand.Text = Convert.ToString(charakter.Stand);
            TB_heimat.Text = Convert.ToString(charakter.Heimat);
            TB_glaube.Text = Convert.ToString(charakter.Glaube);
            TB_merkmale.Text = Convert.ToString(charakter.Merkmale);
            TB_charname.Text = Convert.ToString(charakter.Name);
            TB_beruf.Text = Convert.ToString(charakter.Beruf);
            TB_SPEZIAL.Text = Convert.ToString(charakter.Spetzialisierung);
            TB_EP.Text = Convert.ToString(charakter.Ep);
            TB_ES.Text = Convert.ToString(charakter.Es);
            TB_GELD.Text = Convert.ToString(charakter.Geld);

            SCRVW_Fertigkeiten.Content = charakter.fähigkeiten();
        }

        #endregion
    }
}
