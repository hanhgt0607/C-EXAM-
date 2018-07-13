using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    abstract class Product
    {
        private int _id;
        private string _name;
        private int _price;

        public Product(int id, string name, int price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public Product()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public abstract double computeTax();
        


    

}
}
