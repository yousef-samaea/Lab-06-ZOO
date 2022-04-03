using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Chicken : Birds
    {

        public override void Eat()
        {
            Console.WriteLine("weed its favorit food");
        }

        public override void Sleep()
        {
            Console.WriteLine("of course");
        }

        public override void Sound()
        {
            Console.WriteLine("bak bak bakek");
        }

        public override void Tail()
        {
            Console.WriteLine("yes it dose have a tail");
        }


    }
}
