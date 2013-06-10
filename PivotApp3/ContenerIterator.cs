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
        int collectionIndex;
        int compositeIndex;
        ContenerComposite Head;
        int size;
        
        public ContenerIterator()
        {
            collectionIndex = 0;
            compositeIndex = 0;
            Head=(ContenerComposite)ISTControler.Instance.find("Main");
            size=Head.Childs.Capacity;
            
        }
        public void NextColection()
        {
            if (collectionIndex<size)
            {
            Collection temp = new Collection("");
            Contener current = Head.Childs.ElementAt(collectionIndex);
           
                if (!current.GetType().Equals(temp.GetType()))
                {
                    collectionIndex++;
                    NextColection();
                }
            }
           
        }
        public void NextComposite()
        {
            if (compositeIndex < size)
            {
                ContenerComposite temp = new ContenerComposite("");
                Contener current = Head.Childs.ElementAt(compositeIndex);

                if (!current.GetType().Equals(temp.GetType()))
                {
                    compositeIndex++;
                    NextComposite();
                }
            }

        }
        public void PreviousCollection()
        {
            collectionIndex--;
            if (collectionIndex >0)
            {
                Collection temp = new Collection("");
                Contener current = Head.Childs.ElementAt(collectionIndex);

                if (!current.GetType().Equals(temp.GetType()))
                {
                    PreviousCollection();
                }
            }
        }
        public void PreviousComposite()
        {
            compositeIndex--;
            if (compositeIndex > 0)
            {
                Collection temp = new Collection("");
                Contener current = Head.Childs.ElementAt(compositeIndex);

                if (!current.GetType().Equals(temp.GetType()))
                {
                    PreviousComposite();
                }
            }
        }

        public void Down()
        {
            Head=getCurrentComposite();
        }

        public void Up()
        {
            Head = (ContenerComposite)ISTControler.Instance.find("Main");
        }
            
        public Contener getCurrentCollection()
        {
            return Head.Childs.ElementAt(collectionIndex);
        }
        public ContenerComposite getCurrentComposite()
        {
            return Head;
        }
    }
}
