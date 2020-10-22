using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }
    }

    public class Orange : IFruit
    {
        public bool IsPeeled { get; private set; }

        public string Name
        {
            get { return "Orange"; }
        }

        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "It is now peeled";
            }
        }
        
        public Orange() { }
        public Orange(bool sand)
        {
            IsPeeled = sand;
        }
    }
}
