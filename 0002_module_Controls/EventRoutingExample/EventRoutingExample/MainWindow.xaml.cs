using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace EventRoutingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.MouseEnter += MouseEnterHandler;
            myBorder.MouseEnter += MouseEnterHandler;
            myPanel.MouseEnter += MouseEnterHandler;
            myEllipse.MouseEnter += MouseEnterHandler;
            myRectangle.MouseEnter += MouseEnterHandler;

            this.MouseDown += MouseDownHandler;
            myBorder.MouseDown += MouseDownHandler;
            myPanel.MouseDown += MouseDownHandler;
            myEllipse.MouseDown += MouseDownHandler;
            myRectangle.MouseDown += MouseDownHandler;

            for(int i = 1; i <= 5; ++i)
            {
                Button btn = new Button();
                btn.Content = "Button " + i;
                myPanel.Children.Add(btn);

                //btn.Click += btn_Click;
            }

            myPanel.Click

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = Brushes.Green;
        }

        private void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($"MouseDown: {sender}");
            e.Handled = true;
        }

        private void MouseEnterHandler(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"MouseEnter: {sender}");
        }
    }
}
