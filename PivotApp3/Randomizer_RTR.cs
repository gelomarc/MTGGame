using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PivotApp3
{
    public class Randomizer_RTR
    {
        private static int[] commonNumbers = new int[11];
        private static int[] uncommonNumbers = new int[3];
        private static int[] rareNumbers = new int[1];

        public Randomizer_RTR()
        {
        }
        public static Booster RandomizeBooster_RTR()
        {
            Karta Temp = new Karta();
            Booster FinishedBooster = new Booster();
            for (int i = 0; i < 11; i++)
            {
                Random Number= new Random();
                commonNumbers[i]= Number.Next(1,ISR.getByName("RTR").NumberCommon); //ISR.getByName wyszukuje kolekcji o nazwie RTR
                for(int j = i-1; j>=0; j--)
                    if(commonNumbers[i] == commonNumbers[j])
                    {
                        i--;
                        break;
                    }

                
            }
            for (int i = 0; i < 11; i++)
            {
                int commoncounter=0;
                foreach (Karta Temp in ISR.getByName("RTR").CardLst)
                {
                    if(Temp.rarity==0)
                    {
                        commoncounter++;
                        if (commoncounter == commonNumbers[i])
                        {
                            FinishedBooster.Add(Temp); // dodaje karte do boostera
                            break;
                        }
                    }
                        
                }

            }
            for (int i = 0; i < 3; i++)
            {
                Random Number = new Random();
                uncommonNumbers[i] = Number.Next(1, ISR.getByName("RTR").NumberUCommon);
                for (int j = i - 1; j >= 0; j--)
                    if (uncommonNumbers[i] == uncommonNumbers[j])
                    {
                        i--;
                        break;
                    }


            }
            for (int i = 0; i < 3; i++)
            {
                int uncommoncounter = 0;
                foreach (Karta Temp in ISR.getByName("RTR").CardLst)
                {
                    if (Temp.rarity == 1)
                    {
                        uncommoncounter++;
                        if (uncommoncounter == uncommonNumbers[i])
                        {
                            FinishedBooster.Add(Temp); // dodaje karte do boostera
                            break;
                        }
                    }

                }

            }
            int MythicOrNotCount;
            Random MythicOrNot = new Random();
            MythicOrNotCount = MythicOrNot.Next(0, 7);
            if (MythicOrNotCount == 7)
            {
                Random Number = new Random();
                rareNumbers[0] = Number.Next(1, ISR.getByName("RTR").NumberMRare);
                int mrarecounter = 0;
                foreach (Karta Temp in ISR.getByName("RTR").CardLst)
                {
                    if (Temp.rarity == 3)
                    {
                        mrarecounter++;
                        if (mrarecounter == rareNumbers[0])
                        {
                            FinishedBooster.Add(Temp); // dodaje karte do boostera
                            break;
                        }
                    }

                }
            }
            else
            {
                Random Number = new Random();
                rareNumbers[0] = Number.Next(1, ISR.getByName("RTR").NumberRare);
                int rarecounter = 0;
                foreach (Karta Temp in ISR.getByName("RTR").CardLst)
                {
                    if (Temp.rarity == 2)
                    {
                        rarecounter++;
                        if (rarecounter == rareNumbers[0])
                        {
                            FinishedBooster.Add(Temp); // dodaje karte do boostera
                            break;
                        }
                    }

                }
            }
            
            
            
            return FinishedBooster;
        }
    }
}
