using System;
namespace anipang
{
    public class Vector2
    {
        private int _x, _y;
        public int X
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }
        public Vector2(int y, int x)
        {
            _y = y;
            _x = x;
        }

        public static bool operator ==(Vector2 firstOperand, Vector2 secondOperand)
        {
            return (firstOperand.Y == secondOperand.Y && firstOperand.X == secondOperand.X);
        }

        public static bool operator !=(Vector2 firstOperand, Vector2 secondOperand)
        {
            return (firstOperand.Y != secondOperand.Y && firstOperand.X != secondOperand.X);
        }
    }
}
