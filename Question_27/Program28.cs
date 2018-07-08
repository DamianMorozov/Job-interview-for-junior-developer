using System;
// ReSharper disable UnusedMember.Local
// ReSharper disable ArrangeTypeMemberModifiers

namespace Question_27
{
    internal class Program28
    {
        class A
        {
            public virtual void Show()
            {
                Console.WriteLine("class A");
            }
        }

        class B : A
        {
            public override void Show()
            {
                Console.WriteLine("class A");
            }
        }

        class C : B
        {
            public override void Show()
            {
                Console.WriteLine("class C");
            }
        }

        private static void Main()
        {
            A obj = new C();
            obj.Show();

            Console.ReadKey();
        }
    }
}
