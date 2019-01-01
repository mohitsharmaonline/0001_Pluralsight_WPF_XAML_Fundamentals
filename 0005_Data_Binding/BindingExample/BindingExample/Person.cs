
namespace BindingExample
{
    public class Person
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
            set => _age = value;
        }
    }
}
