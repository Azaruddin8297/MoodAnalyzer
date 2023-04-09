using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalysisException : Exception

    {
        public readonly ExceptionType type;
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            
        } 
        public enum ExceptionType
        {
            Null,Empty
        }
    }
}
