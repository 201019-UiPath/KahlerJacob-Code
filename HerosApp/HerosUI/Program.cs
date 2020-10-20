using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Hero obj = new Hero();

          //  obj.Id = 4;
         //   obj.Name="Alex";
         //   Console.WriteLine($"{obj.Id} {obj.Name}");
            
         //   Console.WriteLine($"{obj.Id} {obj.Name}");

          //  Hero NewHero = new Hero(2, "BatMan");

          //  Console.WriteLine($"{NewHero.Id} {NewHero.Name}");
/*
            Hero obj1 = new Hero();
            Console.Write("What is the Hero ID?");
            obj1.Id=Int32.Parse(Console.ReadLine());
            Console.Write("What is the Hero's Name?");
            obj1.Name=Console.ReadLine();
            Console.Write("Enter the first Power: ");
            obj1.superPowers[0] = Console.ReadLine();

            Console.Write($"{obj1.Id} {obj1.Name} {obj1.superPowers[0]}");


*/
            Hero obj2 = new Hero();
            obj2.ja[0] = new int[2];
            obj2.ja[1] = new int[3];
            obj2.ja[2] = new int[1];

            obj2.ja[0][0] = 10;
            obj2.ja[1][2] = 15;

            Console.WriteLine(obj2.ja.Rank);
            Console.WriteLine(obj2.ja.Length);

            foreach(var rows in obj2.ja)
            {
                for(int i=0; i<rows.Length;i++)
                {
                
                    Console.Write($"{rows[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}