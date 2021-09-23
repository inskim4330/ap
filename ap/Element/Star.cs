using System;
using anipang;
using anipang.View;
namespace anipang.Element
{
    public class Star : Unit
    {
        public Star()
        {
            _shape = '☆';
            _shapeSelected = '★';
            _position = new Vector2(0,0);
        }

        public override void Pang()
        {
            //_shape = '팡';
            //Delay.MakeDelay(500);
            Map.Instance.PresentUnit[Position.Y, Position.X] = null;
        }
    }
}
