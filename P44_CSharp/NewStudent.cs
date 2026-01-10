using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P44_CSharp
{

    class StudentCard : IComparable<StudentCard>, ICloneable
    {
        public string? Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StudentCard? sc)
        {
            return (Series + Number).CompareTo(sc.Series + sc.Number);
        }

        override public string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    class Student : IComparable<Student>, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthDay { get; set; }
        public StudentCard? StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get => new BirthDayComparer(); }
        public static IComparer<Student> FromStudentCard { get => new StudentCardComparer(); }

        public int CompareTo(Student? s)
        {
            return (LastName + FirstName)!.CompareTo(s!.LastName + s.FirstName);
        }

        override public string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {BirthDay.ToShortDateString(),-10} {StudentCard}";
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

        // # 1
        //public void Exam(string date)
        //{
        //    Console.WriteLine($"Екзамен для {LastName + " " + FirstName} назначено на {date}");
        //}

        // #2
        public void Exam(object sender, ExamEventArgs args)
        {
            Teacher t  = sender as Teacher;
            Console.WriteLine($"Викладач {t.Name} назначив екзамен для {LastName + " " + FirstName} " +
                $"по предмету {args.Subject} на {args.Date}. {args.Message}");
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

        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }


    class BirthDayComparer : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            return s1!.BirthDay.CompareTo(s2!.BirthDay);
        }
    }


    class StudentCardComparer : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            return s1!.StudentCard!.CompareTo(s2!.StudentCard);
        }
    }

    //delegate void ExamDelegate(string date);

    //delegate void Action(string date);

    class Teacher
    {

        public string Name { get; set; }

        // # 1
        //public event Action<string> Exam;

        //public void SetExam(string date)
        //{
        //    //Exam?.Invoke(date);

        //    if (Exam != null)
        //    {
        //        Exam(date);
        //    }
        //}


        // # 2

        SortedList<string, EventHandler<ExamEventArgs>> list = new();

        public event EventHandler<ExamEventArgs> Exam
        {
            add 
            {
                Student? s = value!.Target as Student;
                var name = s.LastName + " " + s.FirstName;
                list.Add(name, value);
            }
            remove 
            {
                Student? s = value!.Target as Student;
                var name = s.LastName + " " + s.FirstName;
                list.Remove(name);
            }
        }

        public void SetExam(ExamEventArgs examEvent)
        {
            //Exam?.Invoke(date);

            //if (Exam != null)
            //{
            //    Exam(this, examEvent);
            //}


            foreach (string item in list.Keys)
            {
                list[item](this, examEvent);
            }
        }
    }


    class ExamEventArgs : EventArgs
    {
        public string Subject { get; set; }

        public string Message { get; set; }

        public DateOnly Date { get; set; }
    }
}
