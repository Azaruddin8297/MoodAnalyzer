namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MoodTest mt = new MoodTest("I am sad");
            Console.WriteLine( mt.Analyzer());
            MoodTest mt1 = new MoodTest("I am Any Thing");
            Console.WriteLine(mt1.Analyzer());
            MoodTest mt3 = new MoodTest();
            Console.WriteLine(mt3.Analyzer());
        }
    }
}