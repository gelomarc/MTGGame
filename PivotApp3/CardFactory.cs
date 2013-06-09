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
    public class CardFactory
    {

        private static CardFactory instance;
        private CardFactory()
        {

        }

        ~CardFactory()
        {
            instance = null;
        }

        public static CardFactory GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CardFactory();
                }
                return instance;
            }
        }

        public void CreateBase()
        {//brakuje obslogi isolated storage
            ContenerComposite main = new ContenerComposite("Main");
            Collection rtr = new Collection("Rtr");
            String a;
            System.IO.StreamReader file = new System.IO.StreamReader("cards.txt");
            while ((a = file.ReadLine()) != null)
            {

                String name = "";
                for (int i = 6; i < a.Length; i++)
                {
                    name.Insert(6 - i, a[i].ToString());

                }
                string uri = "/karty/" + name + ".jpg";
                Card newCard = new Card(a[0], (int)a[2], (int)a[4], name, uri);
                rtr.AddCard(newCard);
            }
            file.Close();
            main.Add(rtr);
            ISTControler.Instance.add();
          
        }

    }
}
