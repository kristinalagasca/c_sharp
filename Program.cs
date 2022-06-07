using System;


namespace TestNamespace
{
    class TestClass
    {
        static void Main(string[] args)
        {
            string name = "Tina";
            Console.WriteLine("Hi! My name is " + string.Join(" ", name));

            int favoriteNumber = 13;
            Console.WriteLine("My favorite number is " + string.Join(" ", favoriteNumber));

            bool myBoolean = true;
            Console.WriteLine("My boolean value is " + string.Join(" ", myBoolean));

            double myDouble = 0.9;
            Console.WriteLine("My double value is " + string.Join(" ",myDouble));

            // char myChar = "K";
            // Console.WriteLine("My char value is " + string.Join(" ", myChar));
        }
    }
}
