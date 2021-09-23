using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang.View
{
    class Display
    {
        public static void Map()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            //Console.CursorLeft = 0;
            for (int i = 0; i < anipang.Map.Instance.Height; i++)
            {
                for(int j = 0; j< anipang.Map.Instance.Width; j++)
                {
                    if(anipang.Map.Instance.GetUnit(new Vector2(i, j)) != null)
                    {
                        if(Player.CursorPosition == new Vector2(i, j))
                        {
                            Console.Write(anipang.Map.Instance.GetUnit(new Vector2(i, j)).ShapeSelected);
                        }
                        else
                        {
                            Console.Write(anipang.Map.Instance.GetUnit(new Vector2(i, j)).Shape);
                        }
                        
                    }
                    else
                    {
                        Console.Write("　");
                    }
                    
                }
                Console.WriteLine();
            }
        }


        public static void Update(Action act)
        {
            while (true)
            {
                act();
            }
        }
    }
}
