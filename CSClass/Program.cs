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

        }
    }
}
