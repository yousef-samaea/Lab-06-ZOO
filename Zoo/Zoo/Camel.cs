using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Camel : Mammals, IFriendly
    {

        public override string Eat()
        {
            //Console.WriteLine("cactes its favorit food");
            string a = "cactes its favorit food";
            return a;
        }

        public override string Sleep()
        {
            //Console.WriteLine("of course");
            string a = "of course";
            return a;
        }

        public override string Sound()
        {
            //Console.WriteLine("aaaaa");
            string a = "aaaaa";
            return a;
        }

        public override string Tail()
        {
            //Console.WriteLine("yes it dose have a tail");
            string a = "yes it dose have a tail";
            return a;
        }

        public override string EndureThirst()
        {
            Console.WriteLine("its can EndureThirst for along lime");
            string a = "its can EndureThirst for along lime";
            return a;
        }


        //public void IsFriendly()
        //{
        //    Console.WriteLine("camel is my best frind");
        //}

    }
}
