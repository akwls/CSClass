using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            List<int> list = new List<int>() { 12, 24, 36, 48, 60};
            list.Remove(48);
            list.RemoveAt(0);

            foreach(int item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + item);
            }

            
            Console.WriteLine(Math.Abs(-219));
            Console.WriteLine(Math.Ceiling(2.19));
            Console.WriteLine(Math.Floor(21.9));
            Console.WriteLine(Math.Round(21.5));
            Console.WriteLine(Math.Max(2, 19));
            Console.WriteLine(Math.Min(21, 9));
            Console.WriteLine(Math.PI);

            //Product product = new Product();
            //product.name = "블루베리";
            //product.price = 8000;
            Product product1 = new Product() { name = "블루베리", price = 8000 };
            Product product2 = new Product() { name = "한라봉", price = 4000 };
            Product product3 = new Product() { name = "메론", price = 6000 };


            // Console.WriteLine(product.name + " : " + product.price);
            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
        }
    }
}
