using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityAwarenessBot
{
    public class ChatbotEngine
    {
        private Random random = new Random();

        private MemoryManager memory;

        private Dictionary<string, List<string>> keywordResponses;

        public ChatbotEngine(MemoryManager memoryManager)
        {
            memory = memoryManager;

            keywordResponses = new Dictionary<string, List<string>>()
            {
                {
                    "password",
                    new List<string>()
                    {
                        "Use strong passwords with uppercase, lowercase, numbers, and symbols.",
                        "Avoid using personal details in your passwords.",
                        "Use a different password for every account."
                    }
                },

                {
                    "phishing",
                    new List<string>()
                    {
                        "Be careful of suspicious emails asking for personal information.",
                        "Never click unknown links in emails or messages.",
                        "Scammers often pretend to be trusted companies."
                    }
                },

                {
                    "privacy",
                    new List<string>()
                    {
                        "Review your privacy settings regularly.",
                        "Avoid sharing sensitive information online.",
                        "Use two-factor authentication to improve privacy."
                    }
                },

                {
                    "scam",
                    new List<string>()
                    {
                        "Online scams often create urgency to trick users.",
                        "Never share banking details with strangers online.",
                        "Always verify suspicious messages before responding."
                    }
                }
            };
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            DetectSentiment(input);

            foreach (var keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    memory.LastTopic = keyword;

                    if (input.Contains("interested"))
                    {
                        memory.FavouriteTopic = keyword;

                        return $"Great! I'll remember that you're interested in {keyword}. " +
                               GetRandomResponse(keyword);
                    }

                    return GetRandomResponse(keyword);
                }
            }

            if (input.Contains("another tip") ||
                input.Contains("tell me more") ||
                input.Contains("explain more"))
            {
                if (!string.IsNullOrEmpty(memory.LastTopic))
                {
                    return $"Here is another tip about {memory.LastTopic}: " +
                           GetRandomResponse(memory.LastTopic);
                }
            }

            if (input.Contains("how are you"))
            {
                return "I'm functioning perfectly and ready to help you stay safe online.";
            }

            if (input.Contains("what is cybersecurity"))
            {
                return "Cybersecurity is the practice of protecting systems, networks, and data from cyber threats.";
            }

            if (!string.IsNullOrEmpty(memory.FavouriteTopic))
            {
                return $"As someone interested in {memory.FavouriteTopic}, remember to stay cautious online.";
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }

        private string GetRandomResponse(string keyword)
        {
            var responses = keywordResponses[keyword];

            int index = random.Next(responses.Count);

            return responses[index];
        }

        private void DetectSentiment(string input)
        {
            if (input.Contains("worried"))
            {
                memory.LastTopic = "scam";
            }

            if (input.Contains("frustrated"))
            {
                memory.LastTopic = "password";
            }

            if (input.Contains("curious"))
            {
                memory.LastTopic = "privacy";
            }
        }
    }
}
