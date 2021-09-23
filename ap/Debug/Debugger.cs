using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.Debug
{
    class Debugger
    {
        public void PrintAll()
        {
            //Show all unit
            for (int i = 0; i < Map.Instance.Height; i++)
            {
                for (int j = 0; j < Map.Instance.Width; j++)
                {
                    Console.Write("{0}", Map.Instance.GetUnit(new Vector2(i, j)).Shape);
                }
                Console.WriteLine();
            }
        }
    }
}
