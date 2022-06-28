using System;

namespace CSClass
{
    class Child : Parent
    {

        public new string variable = "shadowing";
        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Chlid(string input) : base(input)");
        }

        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        public override void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }
    }
}