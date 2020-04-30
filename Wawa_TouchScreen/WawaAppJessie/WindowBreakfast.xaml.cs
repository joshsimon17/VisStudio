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
    /// Interaction logic for WindowBreakfast.xaml
    /// </summary>
    public partial class WindowBreakfast : Window
    {
        public WindowBreakfast()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindow();
            newForm.Show();
            this.Close();
        }

        private void BtnBreakfastHoagie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }

        private void BtnBreakfastBurrito_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
