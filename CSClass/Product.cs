using System;

namespace CSClass
{
    class Product
    {
        public static int counter = 0;
        public string name = "노네임";
        public int price = 1000;
        private int id = 0;

        public Product() { }

        public Product(string name, int price)
        {
            this.id = counter;
            counter = counter + 1;
            this.name = name;
            this.price = price;
        }

        // java와 달리 override 키워드 존재
        // 오류 방지.
        // @Override 어노테이션과 동일
        public override string ToString()
        {
            return "(" + this.id + ") "+ this.name + " : " + this.price;
        }

        ~Product()
        {
            Console.WriteLine(this.name + "의 소멸자 호출 ㅠㅅㅠ");
        }
    }
}