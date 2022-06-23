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
    /// Interaktionslogik für New_Item.xaml
    /// </summary>
    public partial class New_Item : Window
    {

        #region Konstruktoren
        public New_Item()
        {
            InitializeComponent();
        }

        public New_Item(Charakter chara)
        {
            InitializeComponent();
            charaa = chara;
        }

        #endregion

        #region Variablen

        private string NAME, SPEZIFIKATIONEN;
        private int GEWICHT, PREIS;
        Charakter charaa;

        #endregion

        #region Buttons

        private void BTN_Verwerfen_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        

        private void BTN_Übernehmen_Click(object sender, RoutedEventArgs e)
        {
            NAME = TB_NAME.Text;
            SPEZIFIKATIONEN = TB_Spez.Text;
            try { GEWICHT = Convert.ToInt32(TB_GEW.Text); } catch { MessageBox.Show("Keine Zahl", "Keine Zahl", MessageBoxButton.OK); }
            try { PREIS = Convert.ToInt32(TB_PREIS.Text); } catch { MessageBox.Show("Keine Zahl", "Keine Zahl", MessageBoxButton.OK); }
            charaa.add_Gegenstand(NAME, GEWICHT, SPEZIFIKATIONEN, PREIS);

            Exit();

        }
        #endregion

        #region hilfsfunktion
        private void Exit()
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
