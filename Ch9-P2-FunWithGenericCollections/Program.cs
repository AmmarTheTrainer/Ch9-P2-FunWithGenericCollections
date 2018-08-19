using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_P2_FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGenericList();
            //UseGenericStack();
            //UseGenericQueue();


            Console.ReadLine();
        }

        private static void UseGenericQueue()
        {
            // Make a Q with three people.
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
            // Peek at first person in Q.
            Console.WriteLine("{0} is first in line!", peopleQ.Peek().FirstName);
            // Remove each person from Q.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            // Try to de-Q again?
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error! {0}", e.Message);
            }

            #region Numbers

            //Queue<int> numbers = new Queue<int>();

            //numbers.Enqueue(1);
            //numbers.Enqueue(2);
            //numbers.Enqueue(3);
            //numbers.Enqueue(4);
            //numbers.Enqueue(5);

            //Console.WriteLine("\nAll items in Queue ");
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(" numbers.Peek() = " + numbers.Peek());

            //numbers.Dequeue();

            //Console.WriteLine(" Dequeue... ");
            //Console.WriteLine(" numbers.Peek() = " + numbers.Peek());

            //Console.WriteLine("\nAll items in Queue ");
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }

        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        private static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();

            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Now look at the top item, pop it, and look again.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop());

            try
            {
                Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }

            #region Custom Examples

            //Stack<int> numbers = new Stack<int>();

            //numbers.Push(1);
            //numbers.Push(3);
            //numbers.Push(5);

            //Console.WriteLine(" numbers.Peek() = " + numbers.Peek());

            //numbers.Pop();
            //numbers.Pop();
            //numbers.Pop();

            //Console.WriteLine(" numbers.Peek() = " + numbers.Peek());

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }

        private static void UseGenericList()
        {
            // Make a List of Person objects, filled with collection/object init syntax.
            List<Person> people = new List<Person>()
            {
                new Person {FirstName= "Homer", LastName="Simpson", Age=47},
                new Person {FirstName= "Marge", LastName="Simpson", Age=45},
                new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
                new Person {FirstName= "Bart", LastName="Simpson", Age=8}
            };
            // Print out # of items in List.
            Console.WriteLine("Items in list: {0}", people.Count);
            // Enumerate over list.
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            // Insert a new person.
            Console.WriteLine("\n->Inserting new person.");
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine("Items in list: {0}", people.Count);
            // Copy data into a new array.
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine("First Names: {0}", p.FirstName);
            }
        }
    }
}
