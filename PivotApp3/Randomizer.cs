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
    public class Randomizer
    {
        public Randomizer()
        {
        }
        public SealedPool RandomizeBooster(String[] Boostery)
        {
            SealedPool FinishedSealedPool = new SealedPool();
            Booster TempBooster = new Booster();
            for (int i = 0; i < 6; i++)
                if (Boostery[i] == "RTR")
                    TempBooster = Randomizer_RTR.RandomizeBooster_RTR();
            FinishedSealedPool.Add(TempBooster);
            return FinishedSealedPool;
        }
    }
}
