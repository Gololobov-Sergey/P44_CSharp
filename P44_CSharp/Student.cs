using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    public partial class Student
    {
        string? name;

        DateOnly birthDay;

        static int count;

        public const string planet = "Earth";

        public readonly string academy;


        public Student(string academy)
        {
            this.academy = academy;
        }

        static Student()
        {
            count = 0;
        }

        public Student(string name, DateOnly bd, string academy)
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
