using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class PlataCard : TipPlata
    {
  
        public void ChooseCard(List<CardTypes> CardList, int _CardID)
        {
            
            foreach(var card in CardList)
            {
                if(card.CardID == _CardID)
                {
                    card.Plata();
                }
            }
             
        }

        

    }
    
}
