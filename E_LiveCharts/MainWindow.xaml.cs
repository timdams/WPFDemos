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
using LiveCharts;
using LiveCharts.Wpf;

namespace E_LiveCharts
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
            //voorbeelde gebaseerd op https://v0.lvcharts.com/App/examples/v1/Wpf/Components#starting-sample
            SeriesCollection ser = new SeriesCollection
                    {
                        new LineSeries
                        {
                            Values = new ChartValues<double> { 3, 5, 7, 4 }
                        },
                        new ColumnSeries
                        {
                            Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                        }
                    };

            

            grafiek.Series = ser;
        }
    }
}