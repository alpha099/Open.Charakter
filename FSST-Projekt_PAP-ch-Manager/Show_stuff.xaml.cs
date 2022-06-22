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
    /// Interaktionslogik für Show_stuff.xaml
    /// </summary>
    public partial class Show_stuff : Window
    {
        #region Variablen
        string STUFF, STUFFNAME;
        #endregion

        #region Konstruktor
        public Show_stuff(string stuffname, string stuff, string stuffheader)
        {
            
            InitializeComponent();
            STUFF = stuff;
            STUFFNAME = stuffname;
            this.Title = stuffname;
            this.LBL_STUFF.Content = stuffheader;

            SCRVW_STUFF.Content = STUFF;
        }
        #endregion

        #region Buttons

        private void BTN_Reload_Click(object sender, RoutedEventArgs e)
        {
            SCRVW_STUFF.Content = STUFF;
        }

        private void BTN_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        #endregion

        #region Hilfsvariablen
        private void Exit() { this.Close(); }

        #endregion
    }
}
