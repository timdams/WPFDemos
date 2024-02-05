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

namespace D2_FileReading2
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
        private string currentFilepath = "";
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Tekst documenten (.txt) | *.txt";
            dlg.DefaultExt = ".txt";

            var result = dlg.ShowDialog();
            if (result == true)
            {
                currentFilepath = dlg.FileName;
                string fileData = System.IO.File.ReadAllText(currentFilepath);
                txbFileData.Text = fileData;

                btnSave.IsEnabled = true;

            }
            else
            {
                currentFilepath = "";
                btnSave.IsEnabled = true;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
           var result= MessageBox.Show(
                "Dit zal de inhoud van het huidige bestand overschrijven.Bent u zeker?",
                "Opgelet!",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);

            if(result== MessageBoxResult.OK)
            {
                System.IO.File.WriteAllText(currentFilepath, txbFileData.Text);
            }
        }
    }
}