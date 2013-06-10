using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class CollectionLibrary
    {
        public void sort(Collection use,String a)
        {
            switch (a)
            {
                case "Kolor":
                    for (int i = 1; i < use.cardList.Count; i++)
                    {
                        for (int j = 0; j < use.cardList.Count - i; j++)
                        {
                            if (use.cardList[j].color > use.cardList[j + 1].color)
                            {
                                Card temp = use.cardList[j];
                                use.cardList.RemoveAt(j);
                                use.cardList.Insert(j + 1, temp);
                            }
                        }
                    }
                    break;
                case "Koszt":
                    for (int i = 1; i < use.cardList.Count; i++)
                    {
                        for (int j = 0; j < use.cardList.Count - i; j++)
                        {
                            if (use.cardList[j].cost > use.cardList[j + 1].cost)
                            {
                                Card temp = use.cardList[j];
                                use.cardList.RemoveAt(j);
                                use.cardList.Insert(j + 1, temp);
                            }
                        }
                    }
                    break;
                case "Rzadkosc":
                    for (int i = 1; i < use.cardList.Count; i++)
                    {
                        for (int j = 0; j < use.cardList.Count - i; j++)
                        {
                            if (use.cardList[j].rarity > use.cardList[j + 1].rarity)
                            {
                                Card temp = use.cardList[j];
                                use.cardList.RemoveAt(j);
                                use.cardList.Insert(j + 1, temp);
                            }
                        }
                    }
                    break;
                case "Nazwa":
                    for (int i = 1; i < use.cardList.Count; i++)
                    {
                        for (int j = 0; j < use.cardList.Count - i; j++)
                        {
                            if (use.cardList[j].name.CompareTo(use.cardList[j + 1].name) > 0)
                            {
                                Card temp = use.cardList[j];
                                use.cardList.RemoveAt(j);
                                use.cardList.Insert(j + 1, temp);
                            }
                        }
                    }
                    break;



            }
        }


    }
}
