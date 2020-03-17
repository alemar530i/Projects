using System;
using System.Collections.Generic;
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CardTypes> CardList = new List<CardTypes>();
            CardList.Add(new MasterCard { CardID = 123 });

            List<Bank> BankList = new List<Bank>();
            BankList.Add(new BCR { BankID = 932 });

            Console.WriteLine("1. Plata cu cardul ***** 2. Plata prin transfer bancar");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) // Incalca principiul open/close
            {
                case 1:
                    {
                        PlataCard plata = new PlataCard();
                        
                        plata.ChooseCard(CardList,123);
        
                        break;
                    }
                case 2:
                    {
                        PlataTransfer plata2 = new PlataTransfer();
                        plata2.ChooseBank(BankList,932);
                       
                        break;
                    }
            }
            
        }
    }
}
