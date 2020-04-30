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

namespace Wawa_TouchScreen
{
    /// <summary>
    /// Interaction logic for WindowSaladsWraps.xaml
    /// </summary>
    public partial class WindowSaladsWraps : Window
    {
        public WindowSaladsWraps()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowLunchDinner();
            newForm.Show();
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSalads_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }

        private void BtnWraps_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }

        private void BtnSaladsCustom_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }
    }
}
