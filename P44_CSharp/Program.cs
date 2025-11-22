using System.Text;

namespace P44_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Слава Україні!";
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();

            // 22.11.2025


            //string? input = Console.ReadLine();

            //string s = "Hello, World!, C#, , C++";
            //s.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(part => Console.WriteLine(part));

            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine(sb.Capacity);
            //sb.Append("Hello");
            //sb.Append(", ");
            //Console.WriteLine(sb.Capacity);
            //sb.AppendLine("C#");
            //sb.AppendLine("World");
            //Console.WriteLine(sb.Capacity);
            //string result = sb.ToString();  
            //Console.WriteLine(result);

            //Console.WriteLine(Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length);


            string? input = Console.ReadLine();

            string golos = "aeiouAEIOUаеєиіїюяАЕЄИІЇЮЯ";
            int count = 0;
            foreach (char c in input!)
            {
                if (golos.Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of vowels: {count}");



            //string[] parts = input!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    parts[i] = new string(parts[i].Reverse().ToArray());
            //}

            //Console.WriteLine(String.Join(" ", parts));

            //Console.Write(s.PadRight(20, '-'));
            //Console.WriteLine(s);

            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //Random rand = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(1, 10);
            //}

            //Console.WriteLine(String.Join(" + ", arr));

            //Console.Write("Array elements : ");
            //Array.ForEach(arr, a=> Console.Write(a + " "));
            //Console.WriteLine();

            //Console.WriteLine($"Number of even elements: {arr.Count(a => a % 2 == 0)}");
            //Console.WriteLine($"Number of odd elements: {arr.Count(a => a % 2 != 0)}");
            //Console.WriteLine($"Number of distinct elements: {arr.Distinct().Count()}");

            //arr.Chunk(3).ToList().ForEach(chunk =>
            //{
            //    Console.Write("Chunk: ");
            //    Array.ForEach(chunk, a => Console.Write(a + " "));
            //    Console.WriteLine();
            //});



            //int[] arr = new int[5];
            //int[] arr2 = { 1,2,3,4,6};
            //int[] arr3 = arr2;
            //Console.WriteLine(arr2[2]);
            //arr2[2] = 100;

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    arr3[i] *= 2;
            //    Console.WriteLine(arr3[i]);
            //}

            //Console.WriteLine(arr3.Max());


            //foreach (int item in arr3)
            //{
            //    //item *= 2;
            //    Console.WriteLine(item);
            //}


            //int[,] arr = new int[,] { { 1, 2, 3 },{ 45, 6, 7 },{ 8, 9, 0 } };

            //arr[1, 0] = 5;

            ////Console.WriteLine(arr.Length);

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //float[,,] arr2 = new float[2, 3, 4];

            //int[][] arr3 = new int[3][];
            //arr3[0] = new int[4] { 1,2,3,4};
            //arr3[1] = new int[2] { 1,2};
            //arr3[2] = new int[6] { 1,2,3,4,5,6};

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    foreach (int item in arr3[i])
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}



            // 19.11.2025

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

            //DateTime d = DateTime.Now;
            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToUniversalTime());

            //Random r = new Random();
            //Console.WriteLine(r.Next(20, 30));
            //Console.WriteLine(r.Next(20, 30));
            //Console.WriteLine(r.Next(20, 30));
            //Console.WriteLine(r.Next(20, 30));
            //Console.WriteLine(r.Next(20, 30));
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());
            //Console.WriteLine(r.NextDouble());

            //Console.WriteLine();

        }
    }
}
