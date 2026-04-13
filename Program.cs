using System;

class Program
{
    static void Main(string[] args)
    {
        UIHelper.DisplayHeader();

        AudioPlayer.PlayGreeting();

        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        name = InputHandler.ValidateName(name);

        Chatbot bot = new Chatbot(name);
        bot.StartChat();
    }
}