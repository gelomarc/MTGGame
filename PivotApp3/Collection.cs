using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class Collection:ContenerComposite
    {
        int NumberRare;
        int NumberMRare;
        int NumberCommon;
        int NumberUCommon;

        public Collection(string NewName) : base(NewName)
        {
            NumberCommon = 0;
            NumberMRare = 0;
            NumberRare = 0;
            NumberUCommon = 0;

        }

        public void AddCard()
        {
        }

        public void RemoveCard()
        { 
        }

        public void SetMemento()
        { 
        }

        public void CreateMemento()
        { 
        }

        public void SetObserver()
        {
        }

        public void RemoveCobserver()
        { 
        }

        public void Notify()
        { 
        }
    }
}
