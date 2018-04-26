using System;

namespace Question_01
{
    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("Class A");
        }

        //public void SomeMethodA()
        //{
        //    Console.WriteLine("SomeMethod A");
        //}
    }

    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("Class B");
        }

        //public new void SomeMethodA()
        //{
        //    Console.WriteLine("new SomeMethod A");
        //}

        //public void SomeMethodB()
        //{
        //    Console.WriteLine("SomeMethod B");
        //}
    }

    internal class Program01
    {
        private static void Main()
        {
            A obj1 = new A();
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();
            //obj2.SomeMethodA();

            A obj3 = new B();
            obj3.Foo();
            //obj3.SomeMethodA();

            Console.ReadKey();
        }

    }
}
