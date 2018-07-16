using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Prog
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Hello World");

            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char myVar = 'M';


            Console.WriteLine("Min Char = {0} Max Char = {1} My Character = {2} ", charMin, charMax, myVar);

            Console.ReadKey();
        }
    }
}
