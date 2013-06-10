using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PivotApp3
{
    class SealedPool:Collection

    {
        public void AddBooster(Booster ExtraBooster)
        {
            this.cardList.AddRange(ExtraBooster.cardList);
        }
    }
}
