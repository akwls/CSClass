using System;

namespace CSClass
{
    class Child : Parent
    {
        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Chlid(string input) : base(input)");
        }
    }
}