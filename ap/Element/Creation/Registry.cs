using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anipang.Element;
using anipang.Element.Creation;
namespace anipang.Element.Creation
{
    class Registry
    {
        private static Registry _instance;
        public static Registry Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Registry();
                }
                return _instance;
            }
        }
        private Registry() 
        {
            RegisterCreator(new CircleCreator());
            RegisterCreator(new ClubCreator());
            RegisterCreator(new DiamondCreator());
            RegisterCreator(new HeartCreator());
            RegisterCreator(new SpadeCreator());
            RegisterCreator(new SquareCreator());
            RegisterCreator(new StarCreator());
        }

        private List<Creator> _prototypeCreator = new List<Creator>();
        public void RegisterCreator(Creator newCreator)
        {
            _prototypeCreator.Add(newCreator);
        }
        public Creator GetCreator(int index)
        {
            return _prototypeCreator[index];
        }
        public Creator GetCreatorArbitrarily()
        {
            Random random = new Random();
            return _prototypeCreator[random.Next(0,_prototypeCreator.Count)];
        }
    }
}
