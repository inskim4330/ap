using System;
using anipang.Element;
namespace anipang.Element.Creation
{
    public abstract class Creator
    {
        protected abstract Unit Create();
        public void PlaceUnit(IPlacer placer)
        {
            Unit unit = Create();
            placer.PlaceToMap(unit);
        }

        public void PlaceUnit(IPlacer placer, Vector2 position)
        {
            Unit unit = Create();
            unit.Position = position;
            placer.PlaceToMap(unit);
        }
    }
}
