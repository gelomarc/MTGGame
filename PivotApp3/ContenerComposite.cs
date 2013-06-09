using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class ContenerComposite
    {
        String Name;
        List<ContenerComposite> Childs;
        int ChildIdicator;
        public ContenerComposite(String NewName)
        {
            Name = NewName;
            Childs = new List<ContenerComposite>();
            ChildIdicator = 0;
        }
        public void Add(ContenerComposite Child)
        {
            Childs.Add(Child);
        }
        public void Delete(ContenerComposite Child)
        {
            Childs.Remove(Child);
            
        }
        public ContenerComposite GetChild()
        {
           ContenerComposite CurrenChild=Childs.ElementAt(ChildIdicator);
           if (CurrenChild != null)
           {
               ChildIdicator++;
           }
           return CurrenChild;
        }
    }
}
