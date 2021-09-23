using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anipang.Element;
using anipang.Element.Creation;

namespace anipang
{
    class Gravity
    {
        private static int _depth;
        public static int Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }
        public static void Apply()
        {
            for (int i = Map.Instance.Height-1; i >=0; i--)
            {
                for (int j = 0; j < Map.Instance.Width; j++)
                {
                    Unit receivedUnit = Map.Instance.GetUnit(new Vector2(i, j));
                    if (receivedUnit == null){
                        int upper = i - 1;
                        if(upper >= 0)
                        {
                            Unit upperUnit = Map.Instance.GetUnit(new Vector2(upper, j));
                            if(upperUnit != null)
                            {
                                Map.Instance.SetUnit(upperUnit, new Vector2(i, j));
                                Map.Instance.PresentUnit[upper, j] = null;
                            }
                            if(upperUnit == null)
                            {
                                continue;
                            }

                        }
                        else // if the unit is uppermost
                        {
                            IPlacer placer = new PositionPlacer();
                            Creator creator = Registry.Instance.GetCreatorArbitrarily();
                            creator.PlaceUnit(placer, new Vector2(i, j));
                        }
                    }
                }
            }
        }
    }
}