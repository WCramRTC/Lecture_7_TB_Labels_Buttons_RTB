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

namespace Lecture_7_TB_Labels_Buttons_RTB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Hotkeys
        // F7 goes to code view
        // Shift + F7 goes to design view

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnHiGerald_Click(object sender, RoutedEventArgs e)
        {
            string gerald = txtGerald.Text;
            string lastName = txtLastName.Text;

            string fullName = gerald + " " + lastName;


            txtDisplay.Text = $"Hi {fullName} ";
        }

    
    }
}
