using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Camel : Mammals, IFriendly
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

        public override void EndureThirst()
        {
            Console.WriteLine("its can EndureThirst for along lime");
        }

        //public void IsFriendly()
        //{
        //    Console.WriteLine("camel is my best frind");
        //}

    }
}
