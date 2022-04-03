using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : Mammals, Strong
    {

        public override void Eat()
        {
            Console.WriteLine("meet its favorit food");
        }

        public override void Sleep()
        {
            Console.WriteLine("most of the day");
        }

        public override void Sound()
        {
            Console.WriteLine("waaaw");
        }

        public override void Tail()
        {
            Console.WriteLine("yes it dose have a tail");
        }


        public abstract class Isdangerous
        {
            public abstract void Dangerous();


            public class Lion : Isdangerous
            {
                public override void Dangerous()
                {
                    Console.WriteLine("yes its dangaras");
                }
            }


        }


    }

}
