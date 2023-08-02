namespace Models
{
    public abstract class Car
    {
        public Car(string _name, string _description, string _color)
        {
            Name = _name;
            Description = _description;
            Color = _color;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Color { get; private set; }

        public override string ToString()
        {
            return $"Car Details\n" +
                $"Name:\t\t{Name}\n" +
                $"Description:\t{Description}\n" +
                $"Color:\t\t{Color}\n";
        }

        //abstract means summary, a sketch, incomplete
        //an abstract method must be implemented in derived/child class.
        //child class with no implementation of parent class abstract method will give error
        //class which contains an abstract method is called an abstract class.
        //abstract class has to be declared with modifier keyword “abstract”.
        //abstract class can contain abstract and non-abstract members.
        //object cannot be created of an abstract class.
        //by creating object of an abstract class , child class methods can’t be accessed.
        //public abstract void Notifier();
    }
}