using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Lion : Mammals, IStrong
    {

        public override string Eat()
        {
            //Console.WriteLine("meet its favorit food");
            string a = "meet its favorit food";
            return a;
        }

        public override string Sleep()
        {
            //Console.WriteLine("most of the day");
            string a = "most of the day";
            return a;
        }

        public override string Sound()
        {
            //Console.WriteLine("waaaw");
            string a = "waaaw";
            return a;
        }

        public override string Tail()
        {
            //Console.WriteLine("yes it dose have a tail");
            string a = "yes it dose have a tail";
            return a;
        }

        public string IsStrong()
        {
           // Console.WriteLine("lion is the king of the savana");
            string a = "lion is the king of the savana";
            return a;
        }



    }

}
