using System;

namespace FinalCsharp
{
    interface Person
    {
    }

    public class Adult : Person
    {
        string firstName;
        string lastName;
        public Adult(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    public class Child : Person
    {
        string firstName;
        string lastName;
        public Child(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Adult a = new Adult("Noushin", "Towf");
            Child c = new Child("Nana", "mala");

            Person[] array = { a, c };
            foreach(Person person in array)
            {

            }

        }
    }
}
