using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public Cat()
        {
            Age = 0;
        }

        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
}