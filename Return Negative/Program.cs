using System;

namespace Return_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static int MakeNegative(int number)
        {
            if (number <= 0)
            {
                return number;
            }
            else
            {
                return number * -1;
            }
        }
    }
}
