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
    /// Interaktionslogik für New_Weapon.xaml
    /// </summary>
    public partial class New_Weapon : Window
    {

        #region Konstruktoren
        public New_Weapon()
        {
            InitializeComponent();
        }

        public New_Weapon(Charakter chara)
        {
            InitializeComponent();
            charr = chara;
        }

        #endregion

        #region Variablen

        private int SCHADEN, PREIS;
        private string NAME, MATERIAL;
        private int REICHWEITE;

        Charakter charr;

        #endregion

        #region Buttons

        private void BTN_Übernehmen_Click(object sender, RoutedEventArgs e)
        {
            SCHADEN = Convert.ToInt32(TB_SCHADEN.Text);
            PREIS = Convert.ToInt32(TB_PREIS.Text);
            NAME = TB_NAME.Text;
            MATERIAL = TB_MATERIAL.Text;
            REICHWEITE = Convert.ToInt32(TB_RANGE.Text);
            charr.add_waffe(NAME, SCHADEN, REICHWEITE, MATERIAL, PREIS);
            Exit();
        }

        private void BTN_Verwerfen_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }
        #endregion

        #region hilfsvariable
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
