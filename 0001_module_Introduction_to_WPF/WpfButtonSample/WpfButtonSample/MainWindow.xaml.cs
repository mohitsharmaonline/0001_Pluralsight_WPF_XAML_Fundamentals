using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfButtonSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button MyButton = new Button();
            MyButton.HorizontalAlignment = HorizontalAlignment.Center;
            MyButton.VerticalAlignment = VerticalAlignment.Center;
            MyButton.FontSize = 24;
            MyButton.FontFamily = new System.Windows.Media.FontFamily("Candara");
            MyButton.Foreground = Brushes.DarkRed;
            MyButton.Content = "_Click me!";
            MainGrid.Children.Add(MyButton);
        }
    }
}
