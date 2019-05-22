using System;
using System.Collections.Generic;
using System.Text;

namespace CYOA_Assignment
{
    class CashRegister
    {

        //member variables (Has A)

        Restaurant restaurant;
        Market market;
        public string paymentTypeCash = "cash";
        public string paymentTypeCard = "card";

        //constructor (Spawner)
        public CashRegister()
        {
            restaurant = new Restaurant();
            market = new Market();

        }
        //member methods(Can Do)
        public void AcceptCash()
        {
            Console.WriteLine("Your total is: " + Restaurant.priceOfPanini() + "Your change is " + );

        }
        public void AcceptGiftCard()
        {
            Console.WriteLine("Your total is: " + priceOfFood);

        }
        public void AcceptCard()
        {
            Console.WriteLine("Your total is: " + priceOfFood);

        }
        public void AcceptCashForTurkeySandwich()
        {
            Console.WriteLine("Your total is: " + priceOfFood + "Your change is " + (priceOfFood - cashOnHand);

        }

    }
}
