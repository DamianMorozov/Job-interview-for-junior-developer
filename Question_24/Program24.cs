// ReSharper disable PossibleNullReferenceException
// ReSharper disable UnusedMember.Local
// ReSharper disable MemberCanBePrivate.Local
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable RedundantCast
#pragma warning disable 659
using System;

namespace Question_24
{
    class A
    {
        public int X;

        public override bool Equals(object obj)
        {
            return X == ((A)obj).X;
        }
    }

    internal class Program24
    {
        private static void Main()
        {
            A a1 = new A { X = 10 };
            A a2 = new A { X = 10 };
            Console.WriteLine((Object)a1 == (Object)a2);
            Console.WriteLine(a1.Equals(a2));

            Console.ReadKey();
        }
    }
}
