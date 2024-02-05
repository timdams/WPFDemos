using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace B_ControlsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToon_Click(object sender, RoutedEventArgs e)
        {
            if (cmbData.Visibility == Visibility.Hidden)
            {
                cmbData.Visibility = Visibility.Visible;
                btnToon.Content = "Verberg combobox";
            }
            else
            {
                cmbData.Visibility = Visibility.Hidden;
                btnToon.Content = "Toon combobox";
            }
        }

        private void cmbData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbData.SelectedItem != null)
            {
                string toShowText = $"U koos voor element met index {cmbData.SelectedIndex}";
               
                ComboBoxItem selectedItem = (ComboBoxItem)cmbData.SelectedItem;
                toShowText += $" daarin staat de tekst {selectedItem.Content}";
               
                MessageBox.Show(toShowText);
            }
        }
    }
}