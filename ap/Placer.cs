using System;
using anipang.Element;
namespace anipang
{
    public class Placer : IPlacer
    {
        private Map _map;
        public void PlaceToMap(Unit unit)
        {
            _map = Map.Instance;
            for (int i = 0; i< _map.Height; i++)
            {
                for(int j = 0; j< _map.Width; j++)
                {
                    bool isCompleted = _map.SetUnit(unit, new Vector2(i, j));
                    if(isCompleted == true)
                    {
                        return;
                    }
                }
            }
        }
    }
}
