using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console_app_library;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validated = false;
            string name="";
            while (!validated)
            {
                Console.WriteLine("Who are you?");
                name = Console.ReadLine();
                validated = name.Validate();
                if (!validated) Console.WriteLine("No numbers please.");
            }
            Console.WriteLine(name + ", this is just a test brother.");
            Console.ReadLine();
        }
    }
}
