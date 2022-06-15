using System;

namespace CSClass
{
    public class Dog : Animal
    {
        string Color;

        public Dog()
        {
            Age = 0;
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}