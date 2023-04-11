using MoodAnalyzer;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void GivenSadMessad_ShouldReturnSad()
        {
            MoodTest mood = new MoodTest("I am in Sad Mood");
            string result = mood.Analyzer();
            Assert.AreEqual(result, "Sad");
        }
        [TestMethod]
        public void GivenHappyMessage_ShouldReturnHappy()
        {
            MoodTest mood = new MoodTest("I am in Happy Mood");
            string result = mood.Analyzer();
            Assert.AreEqual(result, "Happy");
        }
        [TestMethod]
        public void GivenNullMessage_ShouldReturnException()
        {
            MoodTest mood = new MoodTest("I am in Any mood");
            string actual = mood.Analyzer();
            Assert.AreEqual(actual, "Happy");
        }
        [TestMethod]
        public void GivenNullMood_WhenAnalyze_ShouldReturnException()
        {
            string expected = "Mood should not be null";
            try
            {
                MoodTest mood = new MoodTest(null);
                string actual = mood.Analyzer();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMood_ShouldReturnException()
        {
            string expected = "Mood should not be empty";
            try
            {
                MoodTest moodAnalyser = new MoodTest("");
                string actual = moodAnalyser.Analyzer();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}