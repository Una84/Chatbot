using System;
using System.Drawing;
using System.Windows.Forms;

namespace CybersecurityAwarenessBot
{
    public partial class MainForm : Form
    {
        private ChatbotEngine chatbot;

        private MemoryManager memory;

        public MainForm()
        {
            InitializeComponent();

            memory = new MemoryManager();

            chatbot = new ChatbotEngine(memory);

            AudioPlayer.PlayGreeting();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            chatBox.AppendText("You: " + input + Environment.NewLine);

            if (string.IsNullOrEmpty(memory.UserName))
            {
                memory.UserName = input;

                chatBox.AppendText("Bot: Nice to meet you " + memory.UserName + "!" + Environment.NewLine);
            }
            else
            {
                string response = chatbot.GetResponse(input);

                chatBox.AppendText("Bot: " + response + Environment.NewLine);
            }

            txtUserInput.Clear();
        }
    }
}
