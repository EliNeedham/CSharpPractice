using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loop Exercise");

            string [] fruits = {"orange", "banana", "tomato", "pear", "dragonn fruit", "kiwi", "clementine"};
            Console.WriteLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("So much fruit, what's on the menu now {0}? ", fruits[i]);

                //we need to print one period per index going up . so we will need a console write line to display. and we will need to add a period to the periods for each time the loop loops
                int fruit = 1;
                while (fruit <= i)
                {
                    Console.WriteLine(".");

                    fruit++;
                }  
            
            //for (int c = 1; c <= fruits.Length; c++)
                //{
                //    Console.WriteLine(".");
                //}
            }

        }//end Main ()
    }//end class
}//end Namespace
