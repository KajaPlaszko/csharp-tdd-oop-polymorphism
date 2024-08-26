using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IBasket
    {
        List<Drink> drinks = new List<Drink>();

        string name;
        int price;

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetName()
        {
            return this.name;
        }

        public void add(string name, int price)
        {
            this.drinks.Add(new Drink(name, price));
        }
    }
}
