using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Tuna : Fishs
    {

        public override void Eat()
        {
            Console.WriteLine("athor fishs its favorit food");
        }

        public override void Sleep()
        {
            Console.WriteLine("not alot");
        }

        public override void Sound()
        {
            Console.WriteLine("bok bok bok");
        }

        public override void Tail()
        {
            Console.WriteLine("yes it dose have a tail");
        }

        public override void SetDiscrobeTheTast(string taist)
        {
            this.DiscrobeTheTast = taist;

        }

        public override string GetDiscrobeTheTasts()
        {
            return this.DiscrobeTheTast;
        }

  
    }
}
