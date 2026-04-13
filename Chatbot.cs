using System;
using System.Threading;

public class Chatbot
{
    private string userName;

    public Chatbot(string name)
    {
        userName = name;
    }

    public void StartChat()
    {
        UIHelper.TypeText($"\nHello {userName}! Ask me anything about cybersecurity.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠️ Please enter something.");
                continue;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            UIHelper.TypeText("I'm just code, but I'm here to keep you safe online! 😊");
        }
        else if (input.Contains("purpose"))
        {
            UIHelper.TypeText("My purpose is to educate you about cybersecurity threats.");
        }
        else if (input.Contains("password"))
        {
            UIHelper.TypeText("Use strong passwords with letters, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            UIHelper.TypeText("Be careful of suspicious emails asking for personal info.");
        }
        else if (input.Contains("browsing"))
        {
            UIHelper.TypeText("Always check for HTTPS and avoid unsafe websites.");
        }
        else if (input.Contains("explain everything") || input.Contains("what is cybersecurity"))
        {
            UIHelper.TypeText("Cybersecurity involves protecting systems, networks, and data from digital attacks, damage, or unauthorized access. It's important for preventing hackers from stealing sensitive information.");
        }
        else if (input.Contains("what is cybersecurity") || input.Contains("define cybersecurity") || input.Contains("tell me about cybersecurity") || input.Contains("explain cybersecurity") || input.Contains("cybersecurity definition") || input.Contains("cybersecurity"))
        {
            UIHelper.TypeText("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks, theft, or damage. It involves a variety of techniques and tools aimed at preventing unauthorized access and ensuring the confidentiality, integrity, and availability of data and systems.");
        }
        else if (input.Contains("exit"))
        {
            UIHelper.TypeText("Goodbye! Stay safe online 👋");
            Environment.Exit(0);
        }
        else
        {
            UIHelper.TypeText("❓ I didn't quite understand that. Could you rephrase?");
        }
    }
}