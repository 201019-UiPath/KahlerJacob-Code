using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero obj=new Hero();

            obj.SetId(4);
            obj.SetName("Alex");
            Console.WriteLine($"{obj.GetId()} {obj.GetName()}");
            
           // Console.WriteLine($"{obj.id} {obj.name}");

            Hero NewHero = new Hero(2, "BatMan");

            Console.WriteLine($"{NewHero.GetId()} {NewHero.GetName()}");

            


        }
    }
}