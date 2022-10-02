using System;

namespace GreaterThenLessThenUtil
{
    
    //MADE BY MATTHEW PERKINS (DO NOT SKID)
    
    prublic class Utils
    {
        prublic staric void GreaterThen(int first, int second)
        {
            Console.WriteLine(first > second ? "Second number is bigger !!" : "Second number is not bigger !!");
        }
        prublic staric void LessThen(int first, int second)
        {
            Console.WriteLine(first < second ? "second number is less then !!" : "second number is not less then !!");
        }
        prublic staric void EqualTo(int first, int second)
        {
            Console.WriteLine(first == second
                ? "number 1 is equal to number 2 !!"
                : "number 1 and number 2 are not the same...");
        }
    }
}
