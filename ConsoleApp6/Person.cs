using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        public string Name { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Person[] Child {  get; set; }
        public Person Spouse { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public bool GetChild(out Person[] child)
        {
            if (Child != null && Child.Length != 0)
            {
                child = Child;
                return true;
            }
            else { child = null; return false; }
        }

        public void AddFamilyInfo(Person father, Person mother, Person spouse, params Person[] child)
        {
            Father = father;
            Mother = mother;
            Child = child;
            Spouse = spouse;
        }

        public void Print(int i)
        {
            Console.Write($"{new String('=', i)}");
            if (Spouse != null) Console.WriteLine($" {Name} + {Spouse.Name}");
            else Console.WriteLine($" {Name}");
        }

        public void GetFamilyInfo(int i = 0)
        {
            Print(i);
            if (Child != null && Child.Length != 0)
            {
                foreach (var child in Child)
                {child.GetFamilyInfo(i + 2);}
            }
        }
    }
}
