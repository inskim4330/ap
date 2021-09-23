using System;
using anipang;
namespace anipang.Element.Creation
{
    public class CircleCreator : Creator
    {
        protected override Unit Create()
        {
            return new Circle();
        }
    }
}
