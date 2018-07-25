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
            bool MyResult;
            int MyVar1 = 5, MyVar2 = 10;
            MyResult = (MyVar1 >= 5) || (MyVar2 >= 10);
            Console.WriteLine("My Result is = \"{0}\"", MyResult);

       

            if ((MyVar1 == 5) && (MyVar2 == 10))

                Console.WriteLine("The Condition Is True");
            else
                Console.WriteLine("The Condition Is False");

            {

                int MyVar3 = 20;
                string MyResult1;

                if (MyVar3 <= 20)
                {
                    MyResult1 = "My Var3 euqal 20";

                    Console.WriteLine(MyResult1);
                }
                if (MyVar3 >= 20)
                {
                    MyResult1 = "Or More Than 20";
                    Console.WriteLine(MyResult1);

                }
                    Console.ReadKey();

                
            }
        }
    }
}


