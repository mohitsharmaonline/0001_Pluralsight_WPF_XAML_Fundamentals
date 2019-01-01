
using System.ComponentModel;

namespace BindingExample
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private double _age;

        public double Age
        {
            get => _age;
            set
            {
                if(value != _age)
                {
                    _age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
