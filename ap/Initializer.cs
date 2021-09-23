using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anipang.Element.Creation;

namespace anipang
{
    class Initializer
    {
        public static void FillMap()
        {
            IPlacer placer = new Placer();
            int unitCount = 0;

            while (unitCount < Map.Instance.UnitMaxCount)
            {
                Creator creator = Registry.Instance.GetCreatorArbitrarily();
                creator.PlaceUnit(placer);
                unitCount++;
            }
        }
    }
}
