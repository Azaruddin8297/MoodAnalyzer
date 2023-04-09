using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyzerFactor
    {
        
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            //// create the pattern and checks whether constructor name and class name are equal
            string pattern = @"." + constructorName + "";
            Match result = Regex.Match(className, pattern);
            //// if true then create object.
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                //// if no class found then then throw class not found exception
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            //// if constructor name not equal to class name then throw constructor not found exception
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }
    }
}
