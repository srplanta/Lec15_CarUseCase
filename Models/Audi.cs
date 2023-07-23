using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Audi : Car
    {
        public Audi(string _features, decimal _price, string _name, string _description, string _color) : base(_name, _description, _color)
        {
            Features = _features;
            Price = _price;
        }

        public string Features { get; private set; }
        public decimal Price { get; private set; }

        public override string ToString()
        {
            return base.ToString() +    //returns base car class ToString + following info
                $"Features:\t{Features}\n" +
                $"Price:\t\t{Price}\n";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
