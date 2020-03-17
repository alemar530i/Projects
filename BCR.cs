using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BCR : Bank
    {

        public override void AddBank()
        {
            this.BankID = 932;

        }
        public override void Plata()
        {
            Console.WriteLine("BCR");
        }

    }
}
