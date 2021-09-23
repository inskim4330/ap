using System;
using anipang.Element;
namespace anipang
{
    public class PositionPlacer : IPlacer
    {
        public void PlaceToMap(Unit unit)
        {
            Map.Instance.SetUnit(unit, unit.Position);
        }
    }
}