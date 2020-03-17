using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class PlataTransfer : TipPlata
    {
        public void ChooseBank(List<Bank> BankList, int _BankID)
        {

            foreach (var bank in BankList)
            {
                if (bank.BankID == _BankID)
                {
                    bank.Plata();
                }
            }

        }

    }
}
