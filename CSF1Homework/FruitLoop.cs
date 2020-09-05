using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop Exercise");

            string [] fruits = {"orange", "banana", "tomato", "pear", "dragonn fruit", "kiwi", "clementine"};
            Console.WriteLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("So much fruit, what's on the menu now {0}? ", fruits[i]);
            }

        }
    }
}
