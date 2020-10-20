// 1.0 predefined namespace
using System;

// 1.1 Custom defined namespace
namespace helloWorld
{
    class Program
    {
        // Execution starts here
                    // Command Line Arguments
        
        static void Main(string[] args)
        {

            Console.WriteLine(args);
                        Console.WriteLine("Hello World!" + DateTime.Now);
            string name;

            Console.WriteLine("Gimme a Name, Bro!");
            name = Console.ReadLine();
            string Title = "bro";

            Console.WriteLine("Hey, " + name);
           Console.WriteLine($"Welcome {Title} {name}");
        }
    }
}
                   