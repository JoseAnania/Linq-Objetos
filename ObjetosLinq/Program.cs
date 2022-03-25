using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjetosLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tod", 180, 70, Person.Gender.Male),
                new Person("John", 170, 88, Person.Gender.Male),
                new Person("Anna", 150, 48, Person.Gender.Female),
                new Person("Kyle", 164, 77, Person.Gender.Male),
                new Person("Anna", 164, 77, Person.Gender.Female),
                new Person("Maria", 160, 55, Person.Gender.Female),
                new Person("John", 160, 55, Person.Gender.Female),
            };

            Console.WriteLine("1) Personas con nombre de 4 letras");

            var fouCharPeople = from x in people
                                where (x.Name.Length == 4)
                                select x;

            foreach (var item in fouCharPeople)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("2) Mostrar personas ordenadas por peso");

            var orderByWeight = from x in people
                                orderby x.Weight
                                select x;

            foreach (var item in orderByWeight)
            {
                Console.WriteLine($"Name: {item.Name}, Weight: {item.Weight}");
            }

            Console.WriteLine("3) Mostrar sólo las alturas");

            var height = from x in people
                         select x.Height;

            foreach (var item in height)
            {
                Console.WriteLine($"Height: {item}");
            }

            Console.WriteLine("4) Mostrar las personas ordenadas por Nombre y Altura");

            var orderByNameAndHeight = from x in people
                                       orderby x.Name, x.Height
                                       select x;

            foreach (var item in orderByNameAndHeight)
            {
                Console.WriteLine($"Name: {item.Name}, Height: {item.Height}");
            }
        }
    }
}
