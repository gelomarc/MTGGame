using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class ContenerComposite:Contener
    {
        
        int ChildIdicator;
        public List<Contener> Childs;
        public ContenerComposite(String NewName): base(NewName)
        {
            Childs = new List<Contener>();
            ChildIdicator = 0;
        }
        public void Add(Contener Child)
        {
            Childs.Add(Child);
        }
        public void Delete(Contener Child)
        {
            Childs.Remove(Child);
            
        }
        public Contener GetChild()
        {
           Contener CurrenChild=Childs.ElementAt(ChildIdicator);
           if (CurrenChild != null)
           {
               ChildIdicator++;
           }
           return CurrenChild;
        }
    }
}
