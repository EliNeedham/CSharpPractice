using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Please enter a temperature in Celsius that you'd like to convert to Fahrenheit.");
            float celsius = float.Parse(Console.ReadLine());
            float fah = (celsius * (9.0f / 5.0f)) + 32;
            Console.WriteLine($"{celsius} is {fah} degrees in Fahrenheit" );

        }//end Main ()
    }//end Class
}//end Namespace
