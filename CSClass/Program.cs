using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    public class Program
    {
        public static int number = 10;

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

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(52.3));
            Console.WriteLine(MyMath.Abs(-52.3));


            Product prodectX = new Product() { name = "감자", price = 2000 };
            Product prodectY = new Product("고구마", 3000);

            Console.WriteLine(prodectX.name);
            Console.WriteLine(prodectY.name);
            Console.WriteLine(Product.counter + "개가 생성되었습니다.");

            SingleTon singleTon = SingleTon.getInstance();

            // 정적 생성자는 해당 클래스와 관련된 요소를 처음 사용하는 시점에 한번만 호출된다.
            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample(); // 이 때, 한번만 정적 생성자 호출됨.
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");


            // Console.WriteLine("첫번째 위치");
            // Console.WriteLine(Sample.value); // 이 때, 한번만 정적 생성자 호출됨.
            // Console.WriteLine("두 번째 위치");
            // Sample sample = new Sample();
            // Console.WriteLine("세 번째 위치");

            Console.WriteLine();

            // 소멸자는 LIFO 구조.
            // 마지막에 생성된 객체가 가장 먼저 소멸된다.


            Box box = new Box(10, 20);
            box.Width = 200;
            box.Height = 100;
            Console.WriteLine(box.Area);

            box.Height = -10;
            Console.WriteLine(box.Area);

            Box box2 = new Box(-10, -20);
            Console.WriteLine(box2.Area);
            Console.WriteLine();

            Console.WriteLine(Fibbonacci.Get(1));
            Console.WriteLine(Fibbonacci.Get(10));
            Console.WriteLine(Fibbonacci.Get(50));
            Console.WriteLine(Fibbonacci.Get(100));
            Console.WriteLine();

            Cat c = new Cat();
            Dog d = new Dog();

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> Animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            /*foreach(var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
            Console.WriteLine();*/
            foreach(var item in Animals)
            {
                item.Eat();
                item.Sleep();
                if(item is Dog)
                {
                    ((Dog)item).Bark();
                }
                if (item is Cat)
                {
                    ((Cat)item).Meow();
                }
                // item is Animal -> true

                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }

            Console.WriteLine();

            Child ChildA = new Child();
            Child ChildB = new Child("string");

            Console.WriteLine();

            // Shadowing
            int number = 20;
            Console.WriteLine(number);

            Console.WriteLine();

            foreach(var item in Animals)
            {
                item.Eat();
            }

            Console.WriteLine();
        }
    }
}
