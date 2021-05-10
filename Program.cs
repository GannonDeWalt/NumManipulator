using System;

namespace NumManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 12;
            Console.WriteLine(myInt);
            myInt = (myInt^2) + 14 -3;
            Console.WriteLine(myInt);
        }
    }
}
