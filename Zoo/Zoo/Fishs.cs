using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Fishs : Inocean
    {
        public string DiscrobeTheTast;
        public abstract void SetDiscrobeTheTast(string taist);
        public abstract string GetDiscrobeTheTasts();


    }
}
