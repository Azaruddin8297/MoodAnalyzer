namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            MoodTest mt1 = new MoodTest("I am Any Thing");
            Console.WriteLine(mt1.Analyzer());
            Console.WriteLine("***********************");
            MoodTest mt3 = new MoodTest(null);
            Console.WriteLine(mt3.Analyzer());
            Console.WriteLine("***********************");
            MoodTest mt = new MoodTest(string.Empty);
            Console.WriteLine(mt.Analyzer());
        }
    }
}