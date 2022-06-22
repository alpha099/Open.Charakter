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
    /// Interaktionslogik für bedienfeld_charakter.xaml
    /// </summary>
    public partial class bedienfeld_charakter : Window
    {
        #region Konstruktor
        public bedienfeld_charakter(Charakter chara)
        {
            InitializeComponent();
            this.charakter = chara;
        }
        #endregion

        #region Variable
        Charakter charakter;
        #endregion

        #region Buttons
        private void BTN_RNDM_CHAR_Click(object sender, RoutedEventArgs e)
        {
            Charakter_Changefield char_Change = new Charakter_Changefield(charakter);
            char_Change.Show();
        }

        private void BTN_Custom_w_calc_Click(object sender, RoutedEventArgs e)
        {
            custom_calc_char char_custom= new custom_calc_char(charakter);
            char_custom.Show();
        }

        private void BTN_CUSTOM_CHAR_Click(object sender, RoutedEventArgs e)
        {
            New_Custom_Charakter_new newchar = new New_Custom_Charakter_new(charakter);
            newchar.Show();
        }
        #endregion
    }
}
