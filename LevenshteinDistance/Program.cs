using System.Diagnostics;

namespace LevenshteinDistance;
internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        int num;
        // num = Levenshtein.Compare("apple", "apple");
        // Console.WriteLine(num);
        // num = Levenshtein.Compare("apple", "ddapple");
        // Console.WriteLine(num);
        // num = Levenshtein.Compare("apple", "appledd");
        // Console.WriteLine(num);
        // num = Levenshtein.Compare("apple", "apledd");
        // Console.WriteLine(num);
        // num = Levenshtein.Compare("apple", "apledd");
        // Console.WriteLine(num);
        num = Levenshtein.Compare("configure", "configure your docs");
        stopwatch.Stop();
        Console.WriteLine(num);
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}