using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Bank
    {
        public string Name { get; set; }
        public int BankID { get; set; }
        public virtual void AddBank() { }
        public virtual void Plata() { }
        
    }
}
