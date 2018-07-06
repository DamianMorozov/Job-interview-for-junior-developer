using System;
// ReSharper disable RedundantCast

namespace Question_01
{
    internal class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A");
        }
    }

    internal class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B");
        }
    }

    internal class Program01
    {
        private static void Main()
        {
            //B obj1 = new A();  // ошибка
            A obj1 = new A();
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

            B obj4 = new B();
            ((A)obj4).Foo();

            Console.ReadKey();
        }
    }
}
