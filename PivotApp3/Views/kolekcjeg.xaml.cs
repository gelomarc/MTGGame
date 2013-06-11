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
    public partial class kolekcjeg : PhoneApplicationPage
    {
        Kolekcja kolekcja;
        Ist handler;
        
       
        
        public kolekcjeg()
        {
            handler=new Ist();
           // kolekcja=handler.znajdz(kolekcjadoznalezienia); //hiperłącze, ała walnąłem się o ściane
            InitializeComponent();
           // BazaGaleria.ItemsSource = kolekcja.listakart;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/kolekcja2.xaml", UriKind.Relative));
        }
    }
}