using System;

namespace Question_07
{
    internal class Program07
    {
        public class A
        {
            public virtual void Print1()
            {
                Console.Write("A");
            }
            public void Print2()
            {
                Console.Write("A");
            }
        }

        public class B : A
        {
            public override void Print1()
            {
                Console.Write("B");
            }
        }

        public class C : B
        {
            public new void Print2()
            {
                Console.Write("C");
            }
        }

        private static void Main()
        {
            var c = new C();
            A a = c;

            a.Print2();
            a.Print1();
            c.Print2();

            Console.ReadKey();
        }
    }
}
