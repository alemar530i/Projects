using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class CardTypes
    {

        public string Name { get; set; }
        public int CardID { get; set; }
        public virtual void AddCard() { }
        public virtual void Plata() { }
       
    }
}
