using System;

namespace CybersecurityAwarenessBot
{
    public class ChatbotEngine
    {
        private NLPProcessor nlp;
        private MemoryManager memory;
        private TaskManager taskManager;
        private QuizManager quizManager;
        private ActivityLogger logger;

        public ChatbotEngine(
            MemoryManager memory,
            TaskManager taskManager,
            QuizManager quizManager,
            ActivityLogger logger)
        {
            this.memory = memory;
            this.taskManager = taskManager;
            this.quizManager = quizManager;
            this.logger = logger;

            nlp = new NLPProcessor();
        }

        public string ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Please enter a message.";

            string intent = nlp.DetectIntent(input.ToLower());

            logger.Add("User input received: " + input);

            // SENTIMENT DETECTION (simple simulation)
            DetectSentiment(input);

            switch (intent)
            {
                case "ADDTASK":
                    logger.Add("Task intent detected");

                    return HandleTaskCreation(input);

                case "QUIZ":
                    logger.Add("Quiz started");

                    return "Starting cybersecurity quiz... (Open Quiz tab)";

                case "LOG":
                    logger.Add("Activity log requested");

                    return "Open Activity Log tab to view actions.";

                case "PASSWORD":
                    return GetPasswordTip();

                case "PHISHING":
                    return GetPhishingTip();

                case "PRIVACY":
                    return GetPrivacyTip();

                case "SCAM":
                    return GetScamTip();

                default:
                    return GetGeneralResponse(input);
            }
        }

        private void DetectSentiment(string input)
        {
            if (input.Contains("worried"))
            {
                memory.LastSentiment = "worried";
                logger.Add("Sentiment detected: worried");
            }
            else if (input.Contains("curious"))
            {
                memory.LastSentiment = "curious";
                logger.Add("Sentiment detected: curious");
            }
            else if (input.Contains("frustrated"))
            {
                memory.LastSentiment = "frustrated";
                logger.Add("Sentiment detected: frustrated");
            }
        }

        private string HandleTaskCreation(string input)
        {
            string taskTitle = input;

            TaskItem task = new TaskItem
            {
                Title = taskTitle,
                Description = "Cybersecurity task added via chatbot.",
                ReminderDate = DateTime.Now.AddDays(3),
                Completed = false
            };

            taskManager.AddTask(task);

            logger.Add("Task created: " + taskTitle);

            return "Task added successfully. Would you like to set a reminder?";
        }

        private string GetPasswordTip()
        {
            logger.Add("Password tip shown");

            return "Use strong passwords with letters, numbers, and symbols. Avoid reusing passwords.";
        }

        private string GetPhishingTip()
        {
            logger.Add("Phishing tip shown");

            string[] tips =
            {
                "Never click suspicious links in emails.",
                "Check the sender carefully before responding.",
                "Report phishing emails immediately."
            };

            return tips[new Random().Next(tips.Length)];
        }

        private string GetPrivacyTip()
        {
            logger.Add("Privacy tip shown");

            return "Review privacy settings regularly and avoid oversharing personal information.";
        }

        private string GetScamTip()
        {
            logger.Add("Scam tip shown");

            return "Be cautious of messages asking for money or urgent action.";
        }

        private string GetGeneralResponse(string input)
        {
            logger.Add("Fallback response used");

            if (!string.IsNullOrEmpty(memory.UserName))
            {
                return $"Hi {memory.UserName}, I’m here to help you stay safe online. Try asking about passwords, scams, or phishing.";
            }

            return "I’m not sure I understand. Try asking about cybersecurity topics.";
        }
    }
}
