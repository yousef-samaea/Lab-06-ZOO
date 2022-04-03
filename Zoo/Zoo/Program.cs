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
            Tuna redtuna = new();
            Console.Write("The Tuna Sound is ");
            redtuna.Sound();

            Console.WriteLine("Chicken");
            Chicken chik = new();
            chik.Tail();
            Console.Write("The Chicken Sound is ");
            chik.Sound();

            Console.WriteLine("Canar");
            Chicken canar = new();
            canar.Tail();
            Console.Write("The Canar Sound is ");
            canar.Sound();
            bool x;
            x= canar.Doslayeggs();
            Console.WriteLine(value: "do canars layeggs " + x + " it do layeggs");

            Lion l = new();
            string v;
            Lion.Isdangerous();


        }
    }
}
