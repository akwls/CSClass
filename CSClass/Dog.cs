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

        public new void Eat()
        {
            Console.WriteLine("강아지가 와구와구 먹어요");
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}