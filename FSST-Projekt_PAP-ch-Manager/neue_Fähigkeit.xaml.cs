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
    /// Interaktionslogik für neue_Fähigkeit.xaml
    /// </summary>
    public partial class neue_Fähigkeit : Window
    {
        Fertigkeiten fer= new Fertigkeiten();
        Charakter charakter;

        #region Konstruktor
        public neue_Fähigkeit()
        {
            InitializeComponent();
        }
        public neue_Fähigkeit(Charakter Charakter)
        {
            InitializeComponent();
            charakter = Charakter;
        }
        #endregion

        #region Buttons
        private void BTN_Übernehmen_Click(object sender, RoutedEventArgs e)
        {
            fer.change_bonus(Convert.ToInt16(TB_BONI.Text));
            fer.change_name(TB_NAME.Text);
            fer.change_extra(Convert.ToInt32(TB_LEIT.Text));
            charakter.add_fertigkeit(fer);
            this.Close();
        }

        private void BTN_Verwerfen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion


        #region ups
        private void TB_NAME_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        #endregion
    }
}
