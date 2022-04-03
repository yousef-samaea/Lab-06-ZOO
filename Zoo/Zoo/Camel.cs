using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Camel : Mammals
    {

        public override void Eat()
        {
            Console.WriteLine("cactes its favorit food");
        }

        public override void Sleep()
        {
            Console.WriteLine("of course");
        }

        public override void Sound()
        {
            Console.WriteLine("aaaaa");
        }

        public override void Tail()
        {
            Console.WriteLine("yes it dose have a tail");
        }


    }
}
