using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anipang
{
    class Player
    {
        private static bool _isHeld = false;
        public static bool IsHeld
        {
            get
            {
                return _isHeld;
            }
            set
            {
                if(value == true)
                {
                    _isHeld = true;
                    Console.WriteLine("Hold");
                }
                else
                {
                    _isHeld = false;
                    Console.WriteLine("____");
                }
            }
        }
        private static Vector2 _cursorPosition;
        public static Vector2 CursorPosition
        {
            get
            {
                return _cursorPosition;
            }
            set
            {
                _cursorPosition = value;
            }
        }
        public static void GetKey()
        {
            var key = ConsoleKey.Enter;
            if ((Console.KeyAvailable))
            {
                key = Console.ReadKey().Key;
            }
            
            if (key == ConsoleKey.DownArrow)
            {
                Vector2 targetPosition = new Vector2(CursorPosition.Y + 1, CursorPosition.X);
                if (_isHeld == false)
                {
                    CursorPosition = targetPosition;
                }
                else
                {
                    Map.Instance.ExchangeUnit(CursorPosition, targetPosition);
                    _isHeld = false;
                }
            }
            if (key == ConsoleKey.LeftArrow)
            {
                Vector2 targetPosition = new Vector2(CursorPosition.Y, CursorPosition.X - 1);
                if (_isHeld == false)
                {
                    CursorPosition = targetPosition;
                }
                else
                {
                    Map.Instance.ExchangeUnit(CursorPosition, targetPosition);
                    _isHeld = false;
                }
            }
            if (key == ConsoleKey.RightArrow)
            {
                Vector2 targetPosition = new Vector2(CursorPosition.Y, CursorPosition.X + 1);

                if (_isHeld == false)
                {
                    CursorPosition = targetPosition;
                }
                else
                {
                    Map.Instance.ExchangeUnit(CursorPosition, targetPosition);
                    _isHeld = false;
                }
            }
            if (key == ConsoleKey.UpArrow)
            {
                Vector2 targetPosition = new Vector2(CursorPosition.Y - 1, CursorPosition.X);

                if (_isHeld == false)
                {
                    CursorPosition = targetPosition;
                }
                else
                {
                    Map.Instance.ExchangeUnit(CursorPosition, targetPosition);
                    _isHeld = false;

                }
            }
            if (key == ConsoleKey.Spacebar)
            {
                _isHeld = !_isHeld;
            }
        }
    }
}
