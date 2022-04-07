using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Chicken : Birds
    {

        public override string Eat()
        {
           // Console.WriteLine("weed its favorit food");
            string a = "weed its favorit food";
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
            //Console.WriteLine("bak bak bakek");
            string a = "bak bak bakek";
            return a;
        }

        public override string Tail()
        {
            //Console.WriteLine("yes it dose have a tail");
            string a = "it dose have a vary long tail";
            return a;
        }


    }
}
