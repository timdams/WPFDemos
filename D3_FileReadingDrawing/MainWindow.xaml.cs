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

namespace D3_FileReadingDrawing
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

        private void btnLaadBestand_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Tekst documenten (.txt) | *.txt";
            dlg.DefaultExt = ".txt";

            var result = dlg.ShowDialog();
            if (result == true)
            {
                string[] fileData = System.IO.File.ReadAllLines(dlg.FileName);
                ParseEnTekenData(fileData);
            }
        }

        private void ParseEnTekenData(string[] fileData)
        {
            var punten = new PointCollection();

            foreach (var line in fileData)
            {
                var split = line.Split(";");
                int x = int.Parse(split[0]);
                int y = int.Parse(split[1]);

                Point p = new Point(x, y);
                punten.Add(p);
            }


            var tekening = new Polyline
            {
                Stroke = Brushes.Red,
                StrokeThickness = 5,
                Points = punten
            };
            paintCanvas.Children.Add(tekening);
        }
    }
}