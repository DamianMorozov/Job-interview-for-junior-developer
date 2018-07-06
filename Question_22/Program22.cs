using System;
// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable ClassNeverInstantiated.Local
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantAssignment
// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable UseObjectOrCollectionInitializer

namespace Question_22
{
    internal class Program22
    {
        public enum Country
        {
            Usa,
            Russia
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Modify(Person person, int y, Country country)
        {
            person.Name = "Ivanov Ivan Ivanovich";
            person.Age = 30;
            y = 40;
            country = Country.Usa;
        }

        private static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Petrov Ivan Ivanovich";
            person.Age = 20;
            int x = 45;
            Country country = Country.Russia;
            Console.WriteLine(string.Format($"{person.Name}, {person.Age}, {country}, {x}"));

            Modify(person, x, country);
            Console.WriteLine(string.Format($"{person.Name}, {person.Age}, {country}, {x}"));

            Console.ReadKey();
        }
    }
}
