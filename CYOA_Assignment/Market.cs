using System;
using System.Collections.Generic;
using System.Text;

namespace CYOA_Assignment
{
    class Market
    {
        //member variables (Has A)
        public string nameOfMarket = "Steve's Sandwiches";
        public string getTurkeySandwich;
        //public bool hasTurkeySandwich;
        public decimal priceOfTurkeySandwich = 7.00m;
        public decimal twentyDollarBill = 20.0m;
        //public decimal giftCardValue = 20.0m;


        //constructor (Spawner)
        public Market(string BuyTurkeySandwich, decimal PriceOfTurkeySandwich)
        {
            getTurkeySandwich = BuyTurkeySandwich;
            //hasTurkeySandwich = true;
            priceOfTurkeySandwich = decimal.format("{0:C}", Convert.ToInt16(PriceOfTurkeySandwich));
            //twentyDollarBill = decimal.Format("{0:C}", Convert.ToInt32(TwentyDollarBill));
            //giftCardValue = decimal.Format("{0:C}", Convert.ToInt32(giftCardValue));
        }
        //member methods(Can Do)
        public void SellTurkeySandwich(decimal PriceOfTurkeySandwich)
        {
            Console.WriteLine("The market has a Turkey Sandwich for sale, it costs " + PriceOfTurkeySandwich);

        }

        //public void SellGrilledCheese(decimal PriceOfGrilledCheese)
        //{
           //Console.WriteLine("The market has a Grilled Cheese for sale, it costs " + PriceOfGrilledCheese);

        //}
    }
}
