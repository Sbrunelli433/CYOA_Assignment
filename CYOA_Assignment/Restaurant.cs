using System;
using System.Collections.Generic;
using System.Text;

namespace CYOA_Assignment
{
    class Restaurant
    {
        //member variables (Has A)
        public string nameOfRestaurant = "Dave's Restaurant";
        public string getPizza;
        //public bool hasPanini;
        public decimal priceOfPizza = 8.00M;
        public decimal twentyDollarBill = 20.0M;
        //public decimal giftCardValue = 20.0M;


        //constructor (Spawner)
        public Restaurant(string BuyPizza, decimal PriceOfPizza)
        {
            getPizza = BuyPizza;
            //hasPanini = true;
            priceOfPizza = decimal.Format("{0:C}", Convert.ToInt32(PriceOfPizza));
            //twentyDollarBill = decimal.Format("{0:C}", Convert.ToInt32(TwentyDollarBill));
            //giftCardValue = decimal.Format("{0:C}", Convert.ToInt32(giftCardValue));

        }

        //member methods(Can Do)
        public void SellPizza(decimal PriceOfPizza)
        {
            Console.WriteLine("The restaurant has a panini for sale, the price is " + PriceOfPizza);

        }
        //public void SellSalad(decimal PriceOfSalad)
        //{

            //Console.WriteLine("The restaurant has a salad for sale, the price is " + PriceOfSalad);

        //}
    }
}
