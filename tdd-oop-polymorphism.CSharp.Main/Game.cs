using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Game : IBasket
    {
        string name;
        int price;
        List<Game> games = new List<Game>();

        public Game(string name, int price)
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

        public void add()
        {
            this.games.Add(new Game(this.name, this.price));
        }

        public void add(string name, int price)
        {
            this.games.Add(new Game(name, price));
        }
    }
}
