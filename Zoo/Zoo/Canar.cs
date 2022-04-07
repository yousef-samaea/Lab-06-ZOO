using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Canar : Birds
    {
        public override string Eat()
        {
            string a = "seeds its favorit food";
            // Console.WriteLine("seeds its favorit food");
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
            //Console.WriteLine("singing");
            string a = "singing";
            return a;
        }

        public override string Tail()
        {
            //Console.WriteLine("yes it dose have a tail");
            string a = "it dose have a butefull tail";
            return a;
        }



    }
}
