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
    public partial class PivotPage2 : PhoneApplicationPage
    {
        ZbKolekcji kolekcja;
        Ist handler;
        
        
        
        
        public PivotPage2()
        {
            handler=new Ist();
            //kolekcja=handler.znajdz("listakolekcji");
            InitializeComponent();
           // BazaGaleria.ItemsSource = kolekcja.lista;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}