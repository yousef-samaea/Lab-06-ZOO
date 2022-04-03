using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Inocean : Animals1
    {

        public Boolean LiveInocean = true;

        public Boolean IsLiveInocean()
        {
            return LiveInocean;
        }
    }


}
