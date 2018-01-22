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

namespace engine_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainMenu = new Frame();
        public MainWindow()
        {
            InitializeComponent();
            MainScreen.Children.Add(MainMenu);
            MainMenu.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainMenu.HorizontalAlignment = HorizontalAlignment.Stretch;
            MainMenu.VerticalAlignment = VerticalAlignment.Stretch;
            MainMenu.Navigate(new details());
        }

        private void Line_Click(object sender, RoutedEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.Black;
            myLine.X1 = 1;
            myLine.X2 = 250;
            myLine.Y1 = Convert.ToInt64(MainScreen.Height) - 1;
            myLine.Y2 = Convert.ToInt64(MainScreen.Height) - 150;
            //myLine.HorizontalAlignment = HorizontalAlignment.Left;
            //myLine.VerticalAlignment = VerticalAlignment.Bottom;
            myLine.StrokeThickness = 5;
            MainScreen.Children.Add(myLine);
        }
    }
}
