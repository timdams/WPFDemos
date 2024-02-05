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

namespace CanvasPolyline
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
            var points = new PointCollection
                            {
                                new Point(10, 200),
                                new Point(120, 350),
                                new Point(310, 450),
                                new Point(460, 230),
                                // voeg gerust extra punten toe
                            };

            
            //we gebruiken de points collectie om een polyline element te maken
            var polyline = new Polyline
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Points = points
            };
           
            paintCanvas.Children.Add(polyline);

            //Zelfde idee, maar nu gaan we  (manueel) een vierkant tekenen
            //Noot: we kunnen dit ook met Rectangle element
            var otherPoints = new PointCollection
                            {
                                new Point(50, 50),
                                new Point(50, 200),
                                new Point(200, 200),
                                new Point(200, 50),
                                new Point(50, 50),
                            };
            var square = new Polyline
            {
                Stroke = Brushes.Red,
                StrokeThickness = 5,
                Points = otherPoints
            };
            paintCanvas.Children.Add(square);
        }
    }
}