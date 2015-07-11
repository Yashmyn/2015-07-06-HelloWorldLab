using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_07_06_HelloWorldLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask user to input first and last name

            Console.WriteLine();
            Console.Write("What is your first name? ");
            String firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            String lastName = Console.ReadLine();
            Console.WriteLine();

            //write hello and remain on same line

            Console.Write("Hello ");

            //write first and last name entered

            Console.WriteLine(firstName + " " + lastName + "!");

            //keep the console open

            Console.ReadLine();
            

        }
    }
}
