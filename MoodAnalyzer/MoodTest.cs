using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodTest
    {
        public string Message;
        public MoodTest() 
        {
            Message = " ";
        }
        public MoodTest(string Message)
        {
            this.Message = Message;
        }
        public string Analyzer()
        {
            try
            {
                if (Message.Contains("sad"))
                {
                    return "SAD";
                }
                else if (Message.Contains("Happy"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "Cannot Determine The Mood";
                }
            }catch(NullReferenceException)
            {
                return "HAPPYYY";
            }
          
        }
    }
}
