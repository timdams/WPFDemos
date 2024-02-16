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

namespace CanvasTekenen
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

        private bool canPaint = false;
        private void paintCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            canPaint = true;
        }

        private void paintCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            canPaint = false;
        }

        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Height = 2;
                ellipse.Width = 2;
                ellipse.Fill = Brushes.Black;

                Point currentPoint = e.GetPosition(this); //positie van muis opvragen
                Canvas.SetLeft(ellipse, currentPoint.X); //ellipse vertellen op welke x coordinaat (van muis) element op canvas moet komen
                Canvas.SetTop(ellipse, currentPoint.Y);

                paintCanvas.Children.Add(ellipse); //ellipse finaal aan canvas toevoegen
            }
        }


    }
}