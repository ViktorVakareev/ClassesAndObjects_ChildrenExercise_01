using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_ChildrenExercise_01
{
    public class Child : Person
    {
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set 
            {
                if (value > 15)
                {
                    throw new ArgumentException($"{Name}: Children must not be over 15 years old!");
                }
                base.Age = value;
            }
        }
        public Child(string name, int age, string Id) : base(name, age, Id)
        {
        }

    }
}
