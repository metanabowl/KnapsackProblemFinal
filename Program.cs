namespace KnapsackProblemFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int numberOfItems = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem Problem = new Problem(numberOfItems, seed);
            Console.WriteLine("\nItems: ");
            Console.WriteLine(Problem);

            Console.WriteLine("Enter the capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Result Result = Problem.Solve(capacity);
            Console.WriteLine(Result);
        }
    }
}
