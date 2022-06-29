using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationShopLibrary
{
    public class Store
    {
        public List<Workstation> ItemList { get; set; }
        public List<Workstation> ShoppingList { get; set; }

        public Store()
        {
            ItemList = new List<Workstation>();
            ShoppingList  = new List<Workstation>();
        }

        //returns total price of the list
        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var i in ShoppingList)
            {
                totalCost += i.Price;
            }

            ShoppingList.Clear(); //empties the list
            return totalCost;
        }
    }
}
