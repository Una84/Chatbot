using System.Collections.Generic;

namespace CybersecurityAwarenessBot
{
    public class QuizManager
    {
        public List<QuizQuestion> Questions { get; private set; }

        public int Score { get; private set; }

        public int CurrentQuestion { get; private set; }

        public QuizManager()
        {
            Questions = new List<QuizQuestion>();

            LoadQuestions();
        }

        private void LoadQuestions()
        {
            Questions.Add(new QuizQuestion
            {
                Question = "What should you do if you receive an email asking for your password?",

                Options = new List<string>
                {
                    "Reply with password",
                    "Delete it",
                    "Report as phishing",
                    "Ignore it"
                },

                CorrectAnswer = 2,

                Explanation =
                    "Reporting phishing emails helps stop scams."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "True or False: It is safe to use the same password everywhere.",

                Options = new List<string>
                {
                    "True",
                    "False"
                },

                CorrectAnswer = 1,

                Explanation =
                    "Always use unique passwords."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "Which password is strongest?",

                Options = new List<string>
                {
                    "123456",
                    "Password1",
                    "Dog2024",
                    "T9$kL#82@Qa!"
                },

                CorrectAnswer = 3,

                Explanation =
                    "Long, random passwords are strongest."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "What does HTTPS indicate?",

                Options = new List<string>
                {
                    "Secure website connection",
                    "Website is free",
                    "Website is popular",
                    "Website has no ads"
                },

                CorrectAnswer = 0,

                Explanation =
                    "HTTPS encrypts communication."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "True or False: Two-factor authentication increases account security.",

                Options = new List<string>
                {
                    "True",
                    "False"
                },

                CorrectAnswer = 0,

                Explanation =
                    "2FA adds another security layer."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "Which is an example of phishing?",

                Options = new List<string>
                {
                    "Fake bank email",
                    "Official bank app",
                    "Password manager",
                    "Software update"
                },

                CorrectAnswer = 0,

                Explanation =
                    "Phishing pretends to be trusted organizations."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "Should you share OTP codes?",

                Options = new List<string>
                {
                    "Yes",
                    "No"
                },

                CorrectAnswer = 1,

                Explanation =
                    "Never share OTPs."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "Which is safest on public Wi-Fi?",

                Options = new List<string>
                {
                    "VPN",
                    "No password",
                    "Sharing files",
                    "Turning firewall off"
                },

                CorrectAnswer = 0,

                Explanation =
                    "VPN encrypts your connection."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "What should you do before clicking a link?",

                Options = new List<string>
                {
                    "Hover over it",
                    "Click immediately",
                    "Forward it",
                    "Ignore URL"
                },

                CorrectAnswer = 0,

                Explanation =
                    "Always inspect links first."
            });

            Questions.Add(new QuizQuestion
            {
                Question = "True or False: Software updates improve security.",

                Options = new List<string>
                {
                    "True",
                    "False"
                },

                CorrectAnswer = 0,

                Explanation =
                    "Updates fix security vulnerabilities."
            });
        }

        public QuizQuestion GetCurrentQuestion()
        {
            return Questions[CurrentQuestion];
        }

        public bool SubmitAnswer(int answer)
        {
            bool correct =
                answer == Questions[CurrentQuestion].CorrectAnswer;

            if (correct)
            {
                Score++;
            }

            CurrentQuestion++;

            return correct;
        }

        public bool QuizFinished()
        {
            return CurrentQuestion >= Questions.Count;
        }

        public string GetFinalFeedback()
        {
            if (Score == Questions.Count)
                return "Excellent! You're a cybersecurity expert.";

            if (Score >= 8)
                return "Great job! You have strong cybersecurity knowledge.";

            if (Score >= 5)
                return "Good effort! Keep practicing.";

            return "Keep learning to stay safe online.";
        }
    }
}
