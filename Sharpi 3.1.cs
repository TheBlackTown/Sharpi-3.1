using System;

namespace CreateStruct
{
    internal class Program
    {
        private class Person
        {
            private readonly string firstName;
            private readonly string lastName;
            private readonly int age;
            private readonly Genders gender;

            public enum Genders : int
            {
                Male,
                Female
            }
            public Person(string firstName, string lastName, int age, Genders gender)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
                this.gender = gender;
            }

            public override string ToString()
            {
                return $"{firstName} {lastName} ({gender}), age {age}";
            }
        }

        private class Manager : Person
        {
            private readonly string phoneNuber;
            private readonly string officeLocation;

            public Manager(string firstName, string lastName, int age, Genders gender, string phoneNuber, string officeLocation) : base(firstName, lastName, age, gender)
            {
                this.phoneNuber = phoneNuber;
                this.officeLocation = officeLocation;
            }

            public override string ToString()
            {
                return $"{base.ToString()}, {phoneNuber}, {officeLocation}";
            }
        }

        private static void Main(string[] args)
        {
            Person p = new Person("Tony", "Alien", 32, Person.Genders.Male);
            Console.WriteLine(p);

            Manager manager = new Manager("Pol", "Perkov", 26, Person.Genders.Male, "2000", "Los Santos");
            Console.WriteLine(manager);

            Console.ReadKey();
        }
    }
}