using System;

namespace Question_01
{
    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B");
        }
    }

    internal class Program
    {
        private static void Main()
        {
            A obj1 = new A();
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

            Console.ReadKey();
        }
    }
}
