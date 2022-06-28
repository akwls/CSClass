using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public Cat()
        {
            Age = 0;
        }

        public override void Eat()
        {
            Console.WriteLine("고양이가 냠냠 먹어요");
        }

        public void Meow()
        {
            Console.WriteLine("야옹");
        }
    }
}