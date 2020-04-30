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
    /// Interaction logic for WindowLunchDinner.xaml
    /// </summary>
    public partial class WindowLunchDinner : Window
    {
        public WindowLunchDinner()
        {
            InitializeComponent();
        }

        private void BtnSoupsSidesBowls_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowSoupsSidesBowls();
            newForm.Show();
            this.Close();
        }

        private void BtnSaladsWraps_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowSaladsWraps();
            newForm.Show();
            this.Close();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLunchDinner_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowHoagies();
            newForm.Show();
            this.Close();
        }
    }
}
