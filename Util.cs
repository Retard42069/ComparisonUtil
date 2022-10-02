using System;

namespace GreaterThenLessThenUtil
{
    
    //MADE BY MATTHEW PERKINS
    
    public class Utils
    {
        public static void GreaterThen(int first, int second)
        {
            Console.WriteLine(first > second ? "Second nimber is bigger !!" : "Second number is not bigger !!");
        }
        public static void LessThen(int first, int second)
        {
            Console.WriteLine(first < second ? "second number is less then !!" : "second number is not less then !!");
        }
        public static void EqualTo(int first, int second)
        {
            Console.WriteLine(first == second
                ? "number 1 is equal to number 2 !!"
                : "number 1 and number 2 are not the same...");
        }
    }
}
