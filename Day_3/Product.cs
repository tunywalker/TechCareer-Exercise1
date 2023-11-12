using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Product
    {
        private string Name { get; set; }
        private double Price { get; set; }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice(double price)
        {
            this.Price = price*0.20;
        }

    }
}
