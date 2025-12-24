using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{

    class StudentCard : IComparable, ICloneable
    {
        public string? Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            StudentCard sc = obj as StudentCard;
            return (Series + Number).CompareTo(sc.Series + sc.Number);
            throw new NotImplementedException();
        }

        override public string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    class Student : IComparable, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer FromBirthDay { get => new BirthDayComparer(); }
        public static IComparer FromStudentCard { get => new StudentCardComparer(); }

        public int CompareTo(object? obj)
        {
            if(obj is Student)
            {
                Student? s = obj as Student;
                return (LastName + FirstName)!.CompareTo(s!.LastName + s.FirstName);
            }
            throw new ArgumentException("Object is not a Student");
        }

        override public string ToString()
        {
            return $"{FirstName, -10} {LastName, -10} {BirthDay.ToShortDateString(), -10} {StudentCard}";
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = this.StudentCard!.Clone() as StudentCard;
            return temp;
        }

        public void Test()
        {
            Console.WriteLine("Test Student");
        }

        public override int GetHashCode()
        {
            return $"{LastName}{FirstName}".GetHashCode();
        }
    }


    class Group : IEnumerable
    {
        Student[] students;

        public Group()
        {
            students = new Student[]
            {
                new Student
                {
                    FirstName = "Vasya",
                    LastName = "Pupkin",
                    BirthDay = new DateOnly(2000, 1, 1),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123456
                    }
                },
                new Student
                {
                    FirstName = "Anna",
                    LastName = "Frolova",
                    BirthDay = new DateOnly(1999, 5, 15),
                    StudentCard = new StudentCard
                    {
                        Series = "AB",
                        Number = 123455
                    }
                },
                new Student
                {
                    FirstName = "Olga",
                    LastName = "Petrov",
                    BirthDay = new DateOnly(2000, 1, 2),
                    StudentCard = new StudentCard
                    {
                        Series = "AC",
                        Number = 123455
                    }
                },
                new Student
                {
                    FirstName = "Oleg",
                    LastName = "Petrov",
                    BirthDay = new DateOnly(1999, 5, 10),
                    StudentCard = new StudentCard
                    {
                        Series = "AC",
                        Number = 123454
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }


        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }


    class BirthDayComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Student && y is Student)
            {
                Student s1 = x as Student;
                Student s2 = y as Student;
                return s1!.BirthDay.CompareTo(s2!.BirthDay);
            }
            throw new ArgumentException("Objects are not Students");
        }
    }


    class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                Student s1 = x as Student;
                Student s2 = y as Student;
                return s1!.StudentCard!.CompareTo(s2!.StudentCard);
            }
            throw new ArgumentException("Objects are not Students");
        }
    }
}
