namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodTest mt = new MoodTest("I am Happy");
            Console.WriteLine( mt.Analyzer());
        }
    }
}