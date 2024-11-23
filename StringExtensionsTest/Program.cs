using StringExtensions;

class Program
{
    static void Main(string[] args)
    {
        string test1 = "Hello";
        string test2 = "world";

        Console.WriteLine($"Test string: '{test1}' starts with uppercase: {test1.StartsWithUpper()}");
        Console.WriteLine($"Test string: '{test2}' starts with uppercase: {test2.StartsWithUpper()}");

        Console.ReadLine();
    }
}