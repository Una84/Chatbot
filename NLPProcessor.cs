using System;

namespace CybersecurityAwarenessBot
{
    public class NLPProcessor
    {
        public string DetectIntent(string input)
        {
            input = input.ToLower();

            if (input.Contains("quiz") ||
                input.Contains("play game") ||
                input.Contains("test me"))
            {
                return "QUIZ";
            }

            if (input.Contains("add task") ||
                input.Contains("create task") ||
                input.Contains("new task"))
            {
                return "ADDTASK";
            }

            if (input.Contains("remind") ||
                input.Contains("reminder"))
            {
                return "REMINDER";
            }

            if (input.Contains("activity") ||
                input.Contains("what have you done") ||
                input.Contains("show log"))
            {
                return "LOG";
            }

            if (input.Contains("password"))
            {
                return "PASSWORD";
            }

            if (input.Contains("privacy"))
            {
                return "PRIVACY";
            }

            if (input.Contains("phishing"))
            {
                return "PHISHING";
            }

            if (input.Contains("scam"))
            {
                return "SCAM";
            }

            return "UNKNOWN";
        }
    }
}
