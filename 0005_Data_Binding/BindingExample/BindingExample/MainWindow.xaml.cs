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

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // instance of object that will serve as datasource
        Person src = new Person { Name = "Ian", Age = 34.6 };
        public MainWindow()
        {
            InitializeComponent();

            // in constrictor put datasource inside the datacontext of the window.
            this.DataContext = src;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = src.Name + " is " + src.Age;
            MessageBox.Show(message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            src.Age += 0.1;

            //AgeTextbox.GetBindingExpression(dp: TextBox.TextProperty).UpdateTarget();
        }
    }
}
