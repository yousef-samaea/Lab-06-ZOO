using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal interface Strong
    {
        public void IsStrong()
        {
            Console.WriteLine("yes its strong");
        }
        public void IsWeak()
        {
            Console.WriteLine("yes its weak");
        }
    }
}
