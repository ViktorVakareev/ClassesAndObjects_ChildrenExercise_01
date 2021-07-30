using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_ChildrenExercise_01
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string Name { get; set; }
        public virtual int Age { get; set; }  
        // virtual -> because child calass Childneed its own implementation for Age (Age < 15)
        public string Id { get; set; }

        public Person()
        {
        }

        public Person(string name, int age, string id)
        {
            if (age < 0)  
            {
                throw new ArgumentException($"{name}: The age must be a positive number");
            }
            Name = name;
            Age = age;
            Id = id;
        }


        public override string ToString()
        {
            string personInfo = $"{Name} is {Age} years old and with ID {Id}";
            return personInfo;
        }

        public bool Equals(Person other)
        {
            return Id == other.Id;
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
