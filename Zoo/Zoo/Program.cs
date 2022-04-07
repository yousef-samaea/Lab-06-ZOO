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
            string a = redtuna.Sound();
            Console.WriteLine("The Tuna Sound is " +a);
            string b= redtuna.DiscrobeTheTast();
            Console.WriteLine("DiscrobeTheTast" + b);
            Console.WriteLine();


            Console.WriteLine("Chicken");
            Chicken chik = new();
            string c= chik.Tail();
            Console.WriteLine(c);
            string d= chik.Sound();
            Console.WriteLine("The Chicken Sound is " +d);
            Console.WriteLine();


            Console.WriteLine("Canar");
            Canar canar = new();
            string e= canar.Tail();
            Console.WriteLine(e);
            string f = canar.Sound();
            Console.WriteLine("The Canar Sound is " +f);
            bool x;
            x= canar.Doslayeggs();
            Console.WriteLine(value: "do canars layeggs " + x + " it do layeggs");
            Console.WriteLine();


            Console.WriteLine("Lion");
            Lion lion = new();
            bool y;
            string g= lion.Sound();
            Console.Write("The Lion Sound is " +g);
            
            y = lion.IsLiveOnland();
            Console.WriteLine(value: "do lion live in savana " + y + " it is");
            string h = lion.IsStrong();
            Console.WriteLine("IsStrong: " +h);
            Console.WriteLine();


            Console.WriteLine("Camel");
            Mammals camel = new Camel();
            //Console.Write("The camel eats is ");
            string j= camel.Eat();
            string k = camel.EndureThirst();
            string l= camel.IsFriendly();
            string z = camel.IsStrong();
            Console.WriteLine(j);
            //Console.WriteLine(k);
            //Console.WriteLine(l);
            Console.WriteLine(z);




        }
    }
}
