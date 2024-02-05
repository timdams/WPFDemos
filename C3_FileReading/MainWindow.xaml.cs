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

namespace C3_FileReading
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Tekst documenten (.txt) | *.txt";
            dlg.DefaultExt = ".txt";

            var result = dlg.ShowDialog();
            if(result == true)
            {
                string fileData = System.IO.File.ReadAllText(dlg.FileName);
                MessageBox.Show(fileData);
            }
        }
    }
}