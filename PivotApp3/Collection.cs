using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace PivotApp3
{
    class Collection:Contener
    {
        public List<Card> cardList;
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

        public static Collection operator +(Collection a, Collection b)
        {
            Collection sum = new Collection("");
            sum = a;
            sum.cardList.AddRange(b.cardList);
            sum.NumberMRare += b.NumberMRare;
            sum.NumberRare += b.NumberRare;
            sum.NumberUCommon += b.NumberUCommon;
            sum.NumberCommon += b.NumberCommon;
            return sum;
        }
        public BitmapImage Wyszukaj(String a)
        {
            Card b = new Card();
            b.name = a;
            foreach (Card i in cardList)
            {
                if (i.equals(b))
                {
                    Uri uri = new Uri("/karty/" + i.name + ".jpg");
                    BitmapImage retImage = new BitmapImage(uri);
                    return retImage;

                }
            }
            return null;

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
