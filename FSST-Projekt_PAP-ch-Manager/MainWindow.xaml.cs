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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FSST_Projekt_PAP_ch_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Charakter charakter = new Charakter(false);

        #region Konstruktor
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Charakter newchar)
        {
            charakter = newchar;
            InitializeComponent();
            reload_stats();
        }

        #endregion


        #region Buttons

        private void BTN_make_new_Click(object sender, RoutedEventArgs e)
        {
            bedienfeld_charakter newchar = new bedienfeld_charakter(charakter);
            newchar.Show();

            reload_stats();
        }

        private void BTN_Load_Charakter_Click(object sender, RoutedEventArgs e)
        {
            charakter.open_Charakter();
            reload_stats();
        }

        private void BTN_new_skill_Click(object sender, RoutedEventArgs e)
        {
            neue_Fähigkeit fer = new neue_Fähigkeit(charakter);
            fer.Show();
            reload_stats();

        }

        private void BTN_new_thing_Click(object sender, RoutedEventArgs e)
        {
            
            New_Item newitem = new New_Item(charakter);
            newitem.Show();
            reload_stats();
        }

        private void BTN_new_weapon_Click(object sender, RoutedEventArgs e)
        {
            New_Weapon newweapon = new New_Weapon(charakter);
            newweapon.Show();
            reload_stats();

        }

        private void BTN_reload_Click(object sender, RoutedEventArgs e)
        {
            reload_stats();
        }

        private void BTN_show_inv_Click(object sender, RoutedEventArgs e)
        {
            if (charakter.Inventar != null) 
            {
                Show_stuff inventory = new Show_stuff("Inventar", charakter.Inventar(), "Inventar");
                inventory.Show();
            }
            else
            {
                MessageBox.Show("Inventar leer", "Eingabe Ungültig", MessageBoxButton.OK);
            }
            reload_stats();
            
        }

        private void BTN_show_weap_Click(object sender, RoutedEventArgs e)
        {

            if (charakter.waffen != null)
            {
                Show_stuff weaponlist = new Show_stuff("Waffenliste", charakter.waffen(),"Waffen");
                weaponlist.Show();
            }
            else
            {
                MessageBox.Show("Keine Waffen verfügbar", "Eingabe Ungültig", MessageBoxButton.OK);
            }
            reload_stats();
        }

        private void BTN_Save_charakter_Click(object sender, RoutedEventArgs e)
        { 
            reload_stats();
            charakter.save_Charakter();
        }

        private void BTN_change_werte_Click(object sender, RoutedEventArgs e)
        {
            Charakter_Changefield change = new Charakter_Changefield(charakter);
            change.Show();
            reload_stats();
        }

        #endregion

        #region Automation

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            reload_stats();
        }

        #endregion

        #region Hilfsfunktionen

        private void reload_stats()
        {

            LBL_ST.Content = Convert.ToString(charakter.St);
            LBL_GS.Content = Convert.ToString(charakter.Gs);
            LBL_GW.Content = Convert.ToString(charakter.Gw);
            LBL_KO.Content = Convert.ToString(charakter.Ko);
            LBL_IN.Content = Convert.ToString(charakter.In);
            LBL_ZT.Content = Convert.ToString(charakter.Zauberbonus);
            LBL_AU.Content = Convert.ToString(charakter.Au);
            LBL_PA.Content = Convert.ToString(charakter.Pa);
            LBL_WK.Content = Convert.ToString(charakter.Wk);
            LBL_BW.Content = Convert.ToString(charakter.B);
            LBL_RAUFEN.Content = Convert.ToString(charakter.Raufen);
            LBL_AUSB.Content = Convert.ToString(charakter.Ausdauerbonus);
            LBL_SCHADB.Content = Convert.ToString(charakter.Schadensbonus);
            LBL_ANGB.Content = Convert.ToString(charakter.Angriffsbonus);
            LBL_ABWB.Content = Convert.ToString(charakter.Abwehrbonus);
            LBL_RES_K.Content = Convert.ToString(charakter.Resistenzbonus_Körper);
            LBL_RES_G.Content = Convert.ToString(charakter.Resistenzbonus_Geist);
            LBL_LPM.Content = Convert.ToString(charakter.LP);
            LBL_APM.Content = Convert.ToString(charakter.AP);
            LBL_GG.Content = Convert.ToString(charakter.Gg);
            LBL_SG.Content = Convert.ToString(charakter.Sg);
            LBL_GROESSE.Content = Convert.ToString(charakter.Groesse);
            LBL_Gewicht.Content = Convert.ToString(charakter.Gewicht);
            LBL_Grad.Content = Convert.ToString(charakter.Grad);
            LBL_AGE.Content = Convert.ToString(charakter.Alter);
            LBL_HAND.Content = Convert.ToString(charakter.Hand);
            LBL_Gestalt.Content = Convert.ToString(charakter.Gestalt);
            LBL_stand.Content = Convert.ToString(charakter.Stand);
            LBL_heimat.Content = Convert.ToString(charakter.Heimat);
            LBL_glaube.Content = Convert.ToString(charakter.Glaube);
            LBL_merkmale.Content = Convert.ToString(charakter.Merkmale);
            LBL_charname.Content = Convert.ToString(charakter.Name);
            LBL_beruf.Content = Convert.ToString(charakter.Beruf);
            LBL_SPEZIAL.Content = Convert.ToString(charakter.Spetzialisierung);
            LBL_EP.Content = Convert.ToString(charakter.Ep);
            LBL_ES.Content = Convert.ToString(charakter.Es);
            LBL_GELD.Content = Convert.ToString(charakter.Geld);

            SCRVW_Fertigkeiten.Content = charakter.fähigkeiten();
        }
        public void open_char(Charakter newcharakter)
        {
            charakter = newcharakter;
        }

        #endregion

        #region ups

        private void BTN_Save_charakter_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        #endregion

    }
}
