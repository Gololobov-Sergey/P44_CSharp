using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    public partial class Student1
    {
        string? name;

        DateOnly birthDay;

        static int count;

        public const string planet = "Earth";

        public readonly string academy;

        int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new Exception("Invalid age");
                }
                age = value;
            }
        }


        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set
            {   // some validation 
                myVar = value; 
            }
        }


        public int MyProperty1 { get; set; } = 100;

        public string[] MyProperty2 { get; set; } = { "Tcentr", "Ingul" };



        public Student1(string academy)
        {
            this.academy = academy;
        }

        static Student1()
        {
            count = 0;
        }

        public Student1(string name, DateOnly bd, string academy)
        {
            this.name = name;
            birthDay = bd;
            this.academy = academy;
        }

        public static void SetCount(int c)
        {
            //name = "Vasya";
            count = c;
        }


        public void Print()
        {
            Console.WriteLine($"Name = {name}, DB = {birthDay}");
        }


    }
}
