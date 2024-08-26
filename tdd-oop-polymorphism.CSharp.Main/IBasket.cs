using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public interface IBasket
{
        void add(string name, int price);

        int GetPrice();

        string GetName();

}
}
