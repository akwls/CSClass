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

            List<Student> students = new List<Student>()
            {
                new Student() { name = "함기훈", grade = 100 },
                new Student() { name = "가연우", grade = 100 },
                new Student() { name = "김유나", grade = 100 },
                new Student() { name = "김유진", grade = 99 },
                new Student() { name = "김하진", grade = 80 },
                new Student() { name = "박수연", grade = 101 },
                new Student() { name = "박혜원", grade = 77 },
                new Student() { name = "심이진", grade = 100 },
                new Student() { name = "유예영", grade = 33 },
                new Student() { name = "윤주희", grade = 22 },
                new Student() { name = "윤채원", grade = 88 },
            };
            // 마지막 데이터에 , 가 있어도 오류 발생하지 않음.


            //           students.Add(new Student() { name = "함기훈", grade = 100 });
            //           students.Add(new Student() { name = "가연우", grade = 100 });
            //           students.Add(new Student() { name = "김유나", grade = 100 });
            //           students.Add(new Student() { name = "김유진", grade = 99 });
            //           students.Add(new Student() { name = "김하진", grade = 80 });
            //           students.Add(new Student() { name = "박수연", grade = 101 });
            //           students.Add(new Student() { name = "박혜원", grade = 77 });
            //           students.Add(new Student() { name = "심이진", grade = 100 });
            //           students.Add(new Student() { name = "우예영", grade = 33 });
            //           students.Add(new Student() { name = "윤주희", grade = 22 });
            //           students.Add(new Student() { name = "윤채원", grade = 88 });

            // 점수가 60점 이상이 넘는 사람은 제거하기
            /*
            foreach(var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student);
                }
            } 
            */
/*
            for(int i = 0; i<students.Count; i++)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }
*/

            for (int i = students.Count-1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                // Console.WriteLine(item.name + " : " + item.grade);
                Console.WriteLine(item);
            }
        }
    }
}
