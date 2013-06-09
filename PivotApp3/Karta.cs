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
    
    public class Karta
    {
        String nazwa;
        int kolor;
        int koszt;
        String obraz;
        bool wypozyczona;
        public Karta(String nazw, int kolo, int kosz, String obra)
        {
            nazwa = nazw;
            kolor = kolo;
            koszt = kosz;
            obraz = obra;
            wypozyczona = false;
        }
        public Karta()
        {
            nazwa = "";
            kolor = 0;
            koszt = 0;
            obraz = "";
            wypozyczona = false;
        }
        void Wypozycz(Karta egzemplarz)
        {
            egzemplarz.wypozyczona = true;
        }
        void Oddaj(Karta egzemplarz)
        {
            egzemplarz.wypozyczona = false;
        }
        bool Equals(Karta egzemplarz1, Karta egzemplarz2)
        {
            if (egzemplarz1.nazwa == egzemplarz2.nazwa)
                return true;
            return false;
        }
    }
  
}
