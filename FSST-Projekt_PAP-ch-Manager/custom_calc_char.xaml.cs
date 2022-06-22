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
    /// Interaktionslogik für custom_calc_char.xaml
    /// </summary>
    public partial class custom_calc_char : Window
    {
        Charakter newchar = new Charakter(false);

        #region Variablen
        private int ST, GS, GW, KO, IN, ZT, AU, PA, WK, BW;         //Haupteigenschaften
        private int RAUFEN, AUSDAUERBONUS, SCHADENSBONUS, ANGRIFFSBONUS, ABWEHRBONUS, RESISTENZBONUS_KÖRPER, RESISTENZBONUS_GEIST, ZAUBERBONUS, WAHRNEHMUNG, TRINKEN;     //sekundäre eigenschaften
        private int LPMAX, APMAX, GG, SG, GROESSE, GEWICHT, GRAD, ALTER;                           //tertiäre eigenschaften
        private string HAND, GESTALT, STAND, HEIMAT, GLAUBE, MERKMALE, NAME, RASSE;     //Merkmale
        private string BERUF, SPETZIALISIERUNG;
        private int EP, ES;
        private double GELD;
        #endregion

        #region Kontruktoren
        public custom_calc_char()
        {
            InitializeComponent();
        }
        public custom_calc_char(Charakter NEWCHAR)
        {
            InitializeComponent();
            newchar = NEWCHAR;
        }

        #endregion

        #region Buttons
        private void BTN_reload_Click(object sender, RoutedEventArgs e)
        {
            newchar.add_stats_w_random(Convert.ToInt16(TB_ST.Text), Convert.ToInt16(TB_GS.Text), Convert.ToInt16(TB_GW.Text), Convert.ToInt16(TB_KO.Text), Convert.ToInt16(TB_IN.Text), Convert.ToInt16(TB_ZT.Text));
            reload_stats();
        }

        private void BTN_Save_charakter_Click(object sender, RoutedEventArgs e)
        {
            reload();
            newchar.save_Charakter();
        }

        private void BTN_Load_Charakter_Click(object sender, RoutedEventArgs e)
        {
            newchar.open_Charakter();
            reload_stats();
        }

        private void BTN_uebernehmen_Click(object sender, RoutedEventArgs e)
        {
            reload();
            MainWindow win = new MainWindow();
            this.Exit();
        }

        private void BTN_new_thing_Click(object sender, RoutedEventArgs e)
        {
            New_Item newitem = new New_Item(newchar);
            newitem.Show();
            reload_stats();
        }

        private void BTN_show_weap_Click(object sender, RoutedEventArgs e)
        {

            if (newchar.waffen != null)
            {
                Show_stuff weaponlist = new Show_stuff("Waffenliste", newchar.waffen(), "Waffen");
                weaponlist.Show();
            }
            else
            {
                MessageBox.Show("Keine Waffen verfügbar", "Eingabe Ungültig", MessageBoxButton.OK);
            }

        }

        private void BTN_show_inv_Click(object sender, RoutedEventArgs e)
        {
            if (newchar.Inventar != null)
            {
                Show_stuff inventory = new Show_stuff("Inventar", newchar.Inventar(), "Inventar");
                inventory.Show();
            }
            else
            {
                MessageBox.Show("Inventar leer", "Eingabe Ungültig", MessageBoxButton.OK);

            }
        }

        private void BTN_new_weapon_Click(object sender, RoutedEventArgs e)
        {
            New_Weapon newweapon = new New_Weapon(newchar);
            newweapon.Show();
            reload_stats();
        }

        private void BTN_new_skill_Click(object sender, RoutedEventArgs e)
        {
            neue_Fähigkeit fer = new neue_Fähigkeit(newchar);
            fer.Show();
            reload_stats();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        #endregion

        #region hilfsvariablen
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

            newchar.add_stats(ST, GS, GW, KO, IN, ZT, AU, PA, WK, BW, RAUFEN, AUSDAUERBONUS, SCHADENSBONUS, ANGRIFFSBONUS, ABWEHRBONUS, RESISTENZBONUS_KÖRPER, RESISTENZBONUS_GEIST, ZAUBERBONUS, WAHRNEHMUNG, TRINKEN, LPMAX, APMAX, GG, SG, GROESSE, GEWICHT, GRAD, ALTER, HAND, GESTALT, STAND, HEIMAT, GLAUBE, MERKMALE, NAME, RASSE, BERUF, SPETZIALISIERUNG, EP, ES, GELD);
        }

        private void reload_stats()
        {

            TB_ST.Text = Convert.ToString(newchar.St);
            TB_GS.Text = Convert.ToString(newchar.Gs);
            TB_GW.Text = Convert.ToString(newchar.Gw);
            TB_KO.Text = Convert.ToString(newchar.Ko);
            TB_IN.Text = Convert.ToString(newchar.In);
            TB_ZT.Text = Convert.ToString(newchar.Zt);
            TB_AU.Text = Convert.ToString(newchar.Au);
            TB_PA.Text = Convert.ToString(newchar.Pa);
            TB_WK.Text = Convert.ToString(newchar.Wk);
            TB_BW.Text = Convert.ToString(newchar.B);
            TB_RAUFEN.Text = Convert.ToString(newchar.Raufen);
            TB_AUSB.Text = Convert.ToString(newchar.Ausdauerbonus);
            TB_SCHADB.Text = Convert.ToString(newchar.Schadensbonus);
            TB_ANGB.Text = Convert.ToString(newchar.Angriffsbonus);
            TB_ABWB.Text = Convert.ToString(newchar.Abwehrbonus);
            TB_RES_K.Text = Convert.ToString(newchar.Resistenzbonus_Körper);
            TB_RES_G.Text = Convert.ToString(newchar.Resistenzbonus_Geist);
            TB_ZAUB.Text = Convert.ToString(newchar.Zauberbonus);
            TB_LPM.Text = Convert.ToString(newchar.LP);
            TB_APM.Text = Convert.ToString(newchar.AP);
            TB_GG.Text = Convert.ToString(newchar.Gg);
            TB_SG.Text = Convert.ToString(newchar.Sg);
            TB_GROESSE.Text = Convert.ToString(newchar.Groesse);
            TB_Gewicht.Text = Convert.ToString(newchar.Gewicht);
            TB_Grad.Text = Convert.ToString(newchar.Grad);
            TB_AGE.Text = Convert.ToString(newchar.Alter);
            TB_HAND.Text = Convert.ToString(newchar.Hand);
            TB_Gestalt.Text = Convert.ToString(newchar.Gestalt);
            TB_stand.Text = Convert.ToString(newchar.Stand);
            TB_heimat.Text = Convert.ToString(newchar.Heimat);
            TB_glaube.Text = Convert.ToString(newchar.Glaube);
            TB_merkmale.Text = Convert.ToString(newchar.Merkmale);
            TB_charname.Text = Convert.ToString(newchar.Name);
            TB_beruf.Text = Convert.ToString(newchar.Beruf);
            TB_SPEZIAL.Text = Convert.ToString(newchar.Spetzialisierung);
            TB_EP.Text = Convert.ToString(newchar.Ep);
            TB_ES.Text = Convert.ToString(newchar.Es);
            TB_GELD.Text = Convert.ToString(newchar.Geld);

            SCRVW_Fertigkeiten.Content = newchar.fähigkeiten();
        }
        #endregion
    }
}
