﻿using System;
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
    
    public class Card
    {
        public String name;
        public int color;
        public int rarity;
        public int cost;
        public String picture;
        public bool isRent;
        public Card(int newColor, int newRarity, int newCost, String newName, String newPicture)
        {
            name = newName;
            rarity = newRarity;
            color = newColor;
            cost = newCost;
            picture = newPicture;
            isRent = false;
        }
        public Card()
        {
            name = "";
            color = 0;
            cost = 0;
            picture = "";
            isRent = false;
        }
        void Wypozycz()
        {
           isRent = true;
        }
        void Oddaj()
        {
            isRent = false;
        }
        public bool equals(Card egzemplarz1)
        {
            if (name.Equals(egzemplarz1.name))
                return true;
            return false;
        }
    }
  
}
