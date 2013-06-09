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
    public class Sealed
    {
        
       /* public int[] NumeryKartc;
        public int[] NumeryKartu;
        public int[] NumeryKartr; = int[6];
        public int[] NumeryKartm; = int[6];*/
        Booster[] PulaKart = new Booster[6];
        public Sealed()
        {

        }
        public Sealed(String dodatek1, String dodatek2, String dodatek3, String dodatek4, String dodatek5, String dodatek6)
        {
            String[] dodatki = {dodatek1,dodatek2,dodatek3,dodatek4,dodatek5,dodatek6};
           
        }
        ~Sealed()
        {
           /* NumeryKartc=null;
            NumeryKartm=null;
            NumeryKartr=null;
            NumeryKartu=null;*/
            PulaKart = null;
            
        }
        private void Sealeduj()
        {
            for (int i = 0; i < 6; i++)
                PulaKart[i] = Booster.losujBooster();
           /* Random losowa = new Random();
            int iloscMythic = 0;
            for(int i=0;i<6;i++)
            {
            if(losowa.Next(0,7)==7) iloscMythic++;
            }
            NumeryKartc = int[66];
            NumeryKartu = int[15];
            NumeryKartr = int[6-iloscMythic];
            NumeryKartm = int[iloscMythic];*/

        }
    }
}
