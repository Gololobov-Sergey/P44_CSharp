
namespace P44_CSharp
{
    internal class Apple
    {
        public ConsoleColor Color { get; set; }

        public int Weight { get; set; }

        public string Print()
        {
            return $"Apple(Color: {Color}, Weight: {Weight})";
        }

        public static Kompot operator +(Apple a1, Apple a2)
        {
            return new Kompot()
            {
                Apples = new List<Apple>() { a1, a2 }
            };
        }


    }


    class Kompot
    {
        public List<Apple> Apples { get; set; } = [];

        public List<string> Ingradients { get; set; } = [];

        internal void PrintRecipe()
        {
            Console.WriteLine("Ingradients:");
            foreach (var apple in Apples)
            {
                Console.WriteLine($"- {apple.Print()}");
            }
            foreach (var ing in Ingradients)
            {
                Console.WriteLine($"- {ing}");
            }
        }

        public static Kompot operator +(Kompot k, Apple a)
        {
            k.Apples.Add(a);
            return k;
        }

        public static Kompot operator +(Kompot k, string ing)
        {
            k.Ingradients.Add(ing);
            return k;
        }

    }
}