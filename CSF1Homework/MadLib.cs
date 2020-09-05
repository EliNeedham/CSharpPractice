using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Madlib exercise");

            Console.WriteLine("what is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("name a person");
            string person = Console.ReadLine();
            Console.WriteLine("name a place");
            string place = Console.ReadLine();
            Console.WriteLine("give me an adjective");
            string adjective = Console.ReadLine();
            Console.WriteLine("give me a character trait");
            string trait = Console.ReadLine();
            Console.WriteLine($"You and {person} took your {color} car to {place}. You had a {adjective} time. {person} is really {trait} which is why you get along!");
        }
    }
}
