using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        private int totalNumberOfItems;
        public int TotalNumberOfItems
        {
            get
            {
                return totalNumberOfItems;
            }
            private set
            {
                totalNumberOfItems = value;
            }
        }

        private decimal totalAmountOwed;
        public decimal TotalAmontOwed
        {
            get
            {
                return totalAmountOwed;
            }
            private set
            {
                totalAmountOwed = value;
            }
        }

        public decimal GetAveragePricePerItem()
        {
            return (TotalAmontOwed / TotalNumberOfItems);
        }

        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems = +numberOfItems;
            TotalAmontOwed = (pricePerItem * numberOfItems);
        }

        public void Empty()
        {

        }
    }
}
