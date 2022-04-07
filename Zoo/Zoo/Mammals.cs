using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Mammals : Onland, IFriendly, IStrong
    {
        public virtual string EndureThirst()
        {
            //Console.WriteLine("MABY");
            string a = "MABY";
            return a;
        }

        public string IsFriendly()
        {
            Console.WriteLine("camel is my best frind");
            string a = "camel is my best frind";
            return a;
        }

        public string IsStrong()
        {
            // Console.WriteLine("camels is a strong survival animls");
            string a = "camels is a strong survival animls";
            return a;
        }


    }
}
