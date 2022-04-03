using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : Mammals, IStrong
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

        public void IsStrong()
        {
            Console.WriteLine("lion is the king of the savana");
        }



    }

}
