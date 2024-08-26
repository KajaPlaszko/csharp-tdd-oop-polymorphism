using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Book : IBasket
    {
        List<Book> books = new List<Book>();

        string name;
        int price;

        public Book(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

     

        public string GetName()
        {
            return this.name;
        }

        public void add(string name, int price)
        {
            this.books.Add(new Book(name, price));
        }

        public int GetPrice()
        {
            return this.price;
        }
    }
}
