using System;

namespace CSClass
{
    class MyMath
    {
        int some_int = 3;

        // 절댓값 구하는 클래스 메서드
        public static int Abs(int v)
        {
            // some_int = 5; // 클래스 메서드에서 인스턴스 변수 사용 불가.
            // foo(); // 클래스 메서드에서 인스턴스 메서드 사용 불가.
            return (v < 0) ? -v : v;
        }

        public static double Abs(double v)
        {
            // some_int = 5; // 클래스 메서드에서 인스턴스 변수 사용 불가.
            // foo(); // 클래스 메서드에서 인스턴스 메서드 사용 불가.
            return (v < 0) ? -v : v;
        }

        void foo()
        {
            Console.WriteLine("클래스 메서드에서 접근 불가");
        }

    }
}