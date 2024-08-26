using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket 
    {
        List<IBasket> basket = new List<IBasket>();
        public void add(IBasket basket)
        {
            this.basket.Add(basket);
        }


       

        public int getTotal()
        {
            int total = 0;

            foreach (IBasket baskets in this.basket)
            {
                total += baskets.GetPrice();
            }

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IBasket baskets in this.basket)
            {
                if (baskets.GetName().Equals(name))
                {
                    return true;
                }
            }


            return false;
        }
    }
}
