﻿using System;
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

        public MoodTest(string Message)
        {
            this.Message = Message;
        }
        public string Analyzer()
        {
            if (Message.Contains("Happy"))
            {
                return "Happy";
            }
            else
            {
                return "Sad";
            }
        }
    }
}
