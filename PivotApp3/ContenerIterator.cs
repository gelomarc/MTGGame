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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    public class ContenerIterator
    {
        int index;
        private List<Contener> Temp;
        public ContenerIterator()
        {
            index = 0;
           // Temp = (List(ISTControler.Instance.find("Main")));
        }
        public Contener Next()
        {
            //ISTControler.Instance.find("Main").Childs.ElementAt(index);
        }
        public Contener Previous()
        {
        }
        public bool isEnd()
        {
        }
        public Contener getCurrent()
        {
        }
    }
}
