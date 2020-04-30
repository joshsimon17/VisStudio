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

namespace Wawa_TouchScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        ListBox listboxOrder = new ListBox();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnBreakfast_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowBreakfast();
            newForm.Show();
            this.Close();
        }

        private void BtnLunchDinner_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowLunchDinner();
            newForm.Show();
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBeverages_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }

        private void BtnFreshBaked_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This menu item is unavailable");
        }
        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new WindowLunchDinner();
            newForm.Show();
            this.Close();
        }

        private void ListboxOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
