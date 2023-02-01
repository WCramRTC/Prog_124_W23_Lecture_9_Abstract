using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Prog_124_W23_Lecture_9_Abstract
{
    // Abstract

    //   How do you create an abstract class
    // you place the keyword Abstract in front of class

    // An abstract class is used to create a general class that others can inherit from, but you can make an instance of directly
    public abstract class Product
    {
        // Business Case
        // Cold Brew
        // Butter Crossiant
        // Tourist Mug 1
        // Vente Latte

        string _name;
        decimal _price;
        string _sku;

        public Product(string name, decimal price, string sku)
        {
            _name = name;
            _price = price;
            _sku = sku;

        }

        public string Name
        {
            get => _name;
        }

        //   Can you give a body to an abstract method?
        // No, it has to be given a body by any derived class ( child class )
        public abstract bool InStock();

        // override
        public override string ToString()
        {
            return $"Name: {_name} - In stock {InStock()} - Price: {_price.ToString("c")} - Sku: {_sku}";
        }

    }
}
