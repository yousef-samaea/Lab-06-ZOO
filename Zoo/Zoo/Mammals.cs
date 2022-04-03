using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Mammals : Onland, IFriendly, IStrong
    {
        public virtual void EndureThirst()
        {
            Console.WriteLine("MABY");
        }

        public void IsFriendly()
        {
            Console.WriteLine("camel is my best frind");
        }

        public void IsStrong()
        {
            Console.WriteLine("camels is a strong survival animls");
        }


    }
}
