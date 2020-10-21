using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the object using the "new" keyword - generate an instance of a class / blueprint.
            Person person = new Person();
            // The new object has all of the properties that are specified in the class, but they are tied to that object.
            // One object's properties cannot see another object's properties without explicitly passing the values.

            // Default Constructor
            Person defaultPerson = new Person();
            // Partial Constructor
            Person partialPerson = new Person("Test", "Testson");
            // Greedy Constructor
            Person greedyPerson = new Person("Test", "McGreedy", 50);

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine().Trim();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine().Trim();

            Console.Write("Please enter your age: ");
            try
            {
                person.Age = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting to zero.");
                person.Age = 0;
            }
            Console.WriteLine($"Hello, {person.FirstName} {person.LastName} who is {person.Age} years old!");

            person.Birthday();

            Console.WriteLine($"You just had a birthday, you are now {person.Age} years old.");
        }
    }
}