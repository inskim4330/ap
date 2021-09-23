using System;
using anipang.Element.Creation;
using anipang.View;
namespace anipang
{
    public delegate void Action();

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Action act = new Action(Player.GetKey);
            act += new Action(Display.Map);
            act += new Action(Delay.Make);
            act += new Action(Consecutiveness.Examine);
            act += new Action(Display.Map);
            act += new Action(Delay.Make);
            act += new Action(Gravity.Apply);


            Initializer.FillMap();
            Display.Update(act);
        }
    }
}
