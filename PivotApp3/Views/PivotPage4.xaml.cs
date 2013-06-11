using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PivotApp1
{
    public partial class PivotPage4 : PhoneApplicationPage
    {
        Kolekcja kolekcja;
        Ist handler;
       
        
        public PivotPage4()
        {
            handler=new Ist();
          //  kolekcja=handler.znajdz(taliadoprzesłania); //hiperłącze, ała walnąłem się o ściane
            InitializeComponent();
          //  BazaGaleria.ItemsSource = kolekcja.listakart;
        }
    }
}