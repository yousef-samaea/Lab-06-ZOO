using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Onland : Animals1
    {

        public Boolean LiveOnland = true;

        public Boolean IsLiveOnland()
        {
            return LiveOnland;
        }
    }



}
