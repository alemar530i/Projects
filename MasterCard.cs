using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class MasterCard : CardTypes
    {
        
        public override void AddCard()
        {
            this.CardID = 123;
            
        }
        public override void Plata()
        {
            Console.WriteLine("MasterCard");
        }
    }
}
