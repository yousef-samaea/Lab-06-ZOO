using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Canar : Birds
    {
        public override void Eat()
        {
            Console.WriteLine("seeds its favorit food");
        }

        public override void Sleep()
        {
            Console.WriteLine("of course");
        }

        public override void Sound()
        {
            Console.WriteLine("singing");
        }

        public override void Tail()
        {
            Console.WriteLine("yes it dose have a tail");
        }



    }
}
