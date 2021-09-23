using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anipang.Element;

namespace anipang
{
    class Consecutiveness
    {
        public static void Examine()
        {
            Examine(Direction.Horizontal);
            Examine(Direction.Vertical);

            if (Map.Instance.CurUnitForExchange != null && Map.Instance.TargetPosForExchange != null)
            {
                Map.Instance.ExchangeUnit(Map.Instance.TargetPosForExchange.Position, Map.Instance.CurUnitForExchange.Position);
            }
        }
        public enum Direction
        {
            Horizontal,
            Vertical
        }
        private static void Examine(Direction dir)
        {
            Stack<Unit> units = new Stack<Unit>();
            Unit receivedUnit;
            for (int i = 0; i < Map.Instance.Length; i++)
            {
                units.Clear();
                for (int j = 0; j < Map.Instance.Length; j++)
                {

                    receivedUnit = null;
                    
                    if (dir == Direction.Horizontal)
                    {
                        receivedUnit = Map.Instance.GetUnit(new Vector2(i, j));
                    }

                    if (dir == Direction.Vertical)
                    {
                        receivedUnit = Map.Instance.GetUnit(new Vector2(j, i));
                    }

                    if(receivedUnit == null)
                    {
                        units.Clear();
                        continue;
                    }
                    
                    if (units.Count == 0)
                    {
                        units.Push(receivedUnit);
                        continue;
                    }

                    if (0 < units.Count)
                    {
                        if (units.Peek().Shape == receivedUnit.Shape)
                        {
                            units.Push(receivedUnit);
                        }
                        int isEndOfRow = j + 1;
                        if (units.Peek().Shape != receivedUnit.Shape || isEndOfRow == Map.Instance.Length) 
                        {
                            if (3 <= units.Count)
                            {
                                while (1 <= units.Count)
                                {
                                    units.Pop().Pang();
                                }
                                Map.Instance.CurUnitForExchange = null;
                                Map.Instance.TargetPosForExchange = null;
                            }
                            units.Clear();
                            units.Push(receivedUnit);
                        }
                    }
                }
            }
        }
    }
}
