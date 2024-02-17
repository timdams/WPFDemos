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

namespace F2_DatabindingListbox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Auto ab = new Auto();
            ab.Bouwjaar = 2000;
            ab.Merk = "BMW";
            lb.Items.Add(ab);
            Auto ab1 = new Auto();
            ab1.Bouwjaar = 2009;
            ab1.Merk = "Ford";
            lb.Items.Add(ab1);
        }
    }
}