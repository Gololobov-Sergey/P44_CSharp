using System.Text;

namespace P44_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "P44 CSharp";
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();

            Console.WriteLine("Слава Україні!");

            //double a = Convert.ToDouble(Console.ReadLine());
            //int b = Int32.Parse(Console.ReadLine()!);

            //Console.WriteLine(a + b);

            //string? s = Console.ReadLine();

            //int m = 10;

            //Console.WriteLine($"m = {m}");

            //int a = 9;
            //bool f = true;
            //if (a == 0)
            //{
            //    Console.WriteLine(9);
            //}
            //else
            //{
            //    Console.WriteLine("not 9");
            //}

            //string n = "mama";
            //switch (n)
            //{
            //    case "mama":
            //    case "papa":
            //        Console.WriteLine("ndnd");
            //        break;
            //    default:
            //        break;
            //}

            //int m = a == 0 ? 3 : 5;

            //switch (ConsoleColor)
            //{
            //    case ConsoleColor.Black:
            //        break;
            //    case ConsoleColor.DarkBlue:
            //        break;
            //    case ConsoleColor.DarkGreen:
            //        break;
            //    case ConsoleColor.DarkCyan:
            //        break;
            //    case ConsoleColor.DarkRed:
            //        break;
            //    case ConsoleColor.DarkMagenta:
            //        break;
            //    case ConsoleColor.DarkYellow:
            //        break;
            //    case ConsoleColor.Gray:
            //        break;
            //    case ConsoleColor.DarkGray:
            //        break;
            //    case ConsoleColor.Blue:
            //        break;
            //    case ConsoleColor.Green:
            //        break;
            //    case ConsoleColor.Cyan:
            //        break;
            //    case ConsoleColor.Red:
            //        break;
            //    case ConsoleColor.Magenta:
            //        break;
            //    case ConsoleColor.Yellow:
            //        break;
            //    case ConsoleColor.White:
            //        break;
            //    default:
            //        break;
            //}


            //for (int i = 0; i < 10; i++)
            //{

            //}

            //while (true)
            //{

            //}

            //do 
            //{ 
            
            //} while (true);

            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToUniversalTime());

            Random r = new Random();
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.Next(20, 30));
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());

        }
    }
}
