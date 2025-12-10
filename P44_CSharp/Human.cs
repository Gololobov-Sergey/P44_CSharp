using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    internal abstract /*sealed*/ class Human
    {
        public int id;
        string name;

        public Human(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Human: ID={id}, Name={name}";
        }

        public abstract void Me();

    }

    class Employee : Human
    {
        new int id;
        decimal salary;

        public Employee(int id, string name, decimal salary) : base(id, name)
        {
            this.salary = salary;
        }


        override public string ToString()
        {
            return base.ToString() + $", Employee: Salary={salary}";
        }

        public void ShowIDs()
        {
            Console.WriteLine($"Employee.ShowIDs");
        }

        public override void Me()
        {
            Console.WriteLine("I am an Employee");
        }

    }

    class Director : Human
    {
        decimal budget;
        public Director(int id, string name, decimal salary, decimal budget) : base(id, name)
        {
            this.budget = budget;
        }

        public override void Me()
        {
            Console.WriteLine("I am a Director");
        }

        public void ShowID()
        {
            Console.WriteLine($"Director.ShowID");
        }

        public override string ToString()
        {
            return base.ToString() + $", Budget={budget}";
        }
    }
}
