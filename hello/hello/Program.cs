namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Oh, hi, Mark!");
            Console.WriteLine("This is lab work #1: Git basics.");

            Console.Write("What is your name? ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name}!");
            Console.WriteLine($"Today is {DateTime.Now:dd.MM.yyyy}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
