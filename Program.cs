using System;
using System.Collections.Generic;

namespace ClassesAndObjects_ChildrenExercise_01
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>();
            var children = new List<Child>();


            Person person1 = new Person("George Testov" , 40, Guid.NewGuid().ToString());           

            Person person2 = new Person("Jorge Garcia", 18, Guid.NewGuid().ToString());
            Person person3 = new Person("Yordan Yovtchev", 25, Guid.NewGuid().ToString());
            //Person person4 = new Person("Jorg Wrong", -15, Guid.NewGuid().ToString());
            person3 = person1;
            
            var child1 = new Child("George Mulan", 12, Guid.NewGuid().ToString());      

            var child2 = new Child("Jorge Gogov", 14, Guid.NewGuid().ToString());
            //var child3 = new Child("Vincent Gogov", 18, Guid.NewGuid().ToString());
            
            people.Add(person1);
            people.Add(person2);
            children.Add(child1);
            children.Add(child2);

            Console.WriteLine("Adults: ");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            Console.WriteLine("Children: ");
            foreach (var child in children)
            {
                Console.WriteLine(child);
            }
            Console.WriteLine(person1 == person3);
            Console.WriteLine(person1.Name == person3.Name);
            Console.WriteLine(person1.Id == person2.Id);
            Console.WriteLine(child1 == child2);
        }
    }
}
