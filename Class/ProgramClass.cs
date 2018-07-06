// ReSharper disable RedundantCast
using System;

namespace Question_class
{
    internal class A
    {
        public virtual string Foo1()
        {
            return "A.Foo1()";
        }
        public string Foo2()
        {
            return "A.Foo1()";
        }
    }

    internal class B : A
    {
        public override string Foo1()
        {
            return "B.Foo1()";
        }
        public new string Foo2()
        {
            return "B.Foo2()";
        }
    }

    internal class C : B
    {
        public override string Foo1()
        {
            return "C.Foo1()";
        }
        public new string Foo2()
        {
            return "C.Foo2()";
        }
    }

    internal class D : B
    {
        public new string Foo2()
        {
            return "D.Foo2()";
        }
    }

    internal class ProgramClass
    {
        private static void Main()
        {
            A a = new A();
            Console.WriteLine("A a = new A();");
            Console.WriteLine("a.Foo1() == " + a.Foo1());
            Console.WriteLine("a.Foo2() == " + a.Foo2());
            Console.WriteLine();

            B b = new B();
            Console.WriteLine("B b = new B();");
            Console.WriteLine("b.Foo1() == " + b.Foo1());
            Console.WriteLine("b.Foo2() == " + b.Foo2());
            Console.WriteLine();

            C c = new C();
            Console.WriteLine("C c = new C();");
            Console.WriteLine("c.Foo1() == " + c.Foo1());
            Console.WriteLine("c.Foo2() == " + c.Foo2());
            Console.WriteLine();

            D d = new D();
            Console.WriteLine("D d = new D();");
            Console.WriteLine("d.Foo1() == " + d.Foo1());
            Console.WriteLine("d.Foo2() == " + d.Foo2());
            Console.WriteLine();

            Console.WriteLine("((A)b).Foo1() == " + ((A)b).Foo1());
            Console.WriteLine("((A)b).Foo2() == " + ((A)b).Foo2());
            Console.WriteLine();

            Console.WriteLine("((B)c).Foo1() == " + ((B)c).Foo1());
            Console.WriteLine("((B)c).Foo2() == " + ((B)c).Foo2());
            Console.WriteLine();

            Console.WriteLine("((A)c).Foo1() == " + ((A)c).Foo1());
            Console.WriteLine("((A)c).Foo2() == " + ((A)c).Foo2());
            Console.WriteLine();

            Console.WriteLine("((B)d).Foo1() == " + ((B)d).Foo1());
            Console.WriteLine("((B)d).Foo2() == " + ((B)d).Foo2());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
