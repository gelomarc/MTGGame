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
    public class FabrykaKart
    {
        
        private static Karta instancja;
        private FabrykaKart() 
        {

        }

   public static Karta Instancja
   {
      get 
      {
         if (instancja == null)
         {
            instancja = new Karta();
         }
         return instancja;
      }
   }
    }
}
