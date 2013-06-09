using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class Collection:Contener
    {
        List<Card> cardList;
        int NumberRare;
        int NumberMRare;
        int NumberCommon;
        int NumberUCommon;

        public Collection(string NewName) : base(NewName)
        {
            cardList = new List<Card>();
            NumberCommon = 0;
            NumberMRare = 0;
            NumberRare = 0;
            NumberUCommon = 0;

        }

        public void AddCard(Card newCard)
        {
            cardList.Add(newCard);
            switch(newCard.rarity){
                case 0:
                    NumberMRare++;
                    break;
                case 1:
                    NumberRare++;
                    break;
                case 2:
                    NumberUCommon++;
                    break;
                default :
                    NumberCommon++;
                    break;
            }

           
        }

        public void RemoveCard(Card deletedCard)
        {
            cardList.Remove(deletedCard);

            switch (deletedCard.rarity)
            {
                case 0:
                    NumberMRare--;
                    break;
                case 1:
                    NumberRare--;
                    break;
                case 2:
                    NumberUCommon--;
                    break;
                default:
                    NumberCommon--;
                    break;
            }

        }

        public void SetMemento()
        { 
        }

        public void CreateMemento()
        { 
        }

        public void SetObserver()
        {
        }

        public void RemoveCobserver()
        { 
        }

        public void Notify()
        { 
        }
    }
}
