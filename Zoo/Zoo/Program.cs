using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuna");
            Fishs redtuna = new Tuna();
            Console.Write("The Tuna Sound is ");
            redtuna.Sound();
            redtuna.DiscrobeTheTast();
            Console.WriteLine();


            Console.WriteLine("Chicken");
            Chicken chik = new();
            chik.Tail();
            Console.Write("The Chicken Sound is ");
            chik.Sound();
            Console.WriteLine();


            Console.WriteLine("Canar");
            Canar canar = new();
            canar.Tail();
            Console.Write("The Canar Sound is ");
            canar.Sound();
            bool x;
            x= canar.Doslayeggs();
            Console.WriteLine(value: "do canars layeggs " + x + " it do layeggs");
            Console.WriteLine();


            Console.WriteLine("Lion");
            Lion lion = new();
            string v;
            bool y;
            Console.Write("The Lion Sound is ");
            lion.Sound();
            y = lion.IsLiveOnland();
            Console.WriteLine(value: "do lion live in savana " + y + " it is");
            lion.IsStrong();
            Console.WriteLine();


            Console.WriteLine("Camel");
            Mammals camel = new Camel();
            //Console.Write("The camel eats is ");
            camel.Eat();
            camel.EndureThirst();
            camel.IsFriendly();
            camel.IsStrong();



        }
    }
}
