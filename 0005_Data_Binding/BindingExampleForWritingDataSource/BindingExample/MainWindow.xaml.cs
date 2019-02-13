using System.Collections.Generic;
using System.Windows;

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // instance of object that will serve as datasource
        Person src = new Person { Name = "Ian", Age = 34.6 };
        List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            people.Add(src);
            people.Add(new Person { Name = "Mike", Age = 62.5 });
            people.Add(new Person { Name = "Brian", Age = 3.5 });

            // in constrictor put datasource inside the datacontext of the window.
            this.DataContext = people;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
