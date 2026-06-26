using System;
using System.Windows.Forms;

namespace CybersecurityAwarenessBot
{
    public partial class MainForm : Form
    {
        private MemoryManager memory;
        private TaskManager taskManager;
        private QuizManager quizManager;
        private ActivityLogger logger;
        private ChatbotEngine chatbot;

        public MainForm()
        {
            InitializeComponent();

            memory = new MemoryManager();
            taskManager = new TaskManager();
            quizManager = new QuizManager();
            logger = new ActivityLogger();

            chatbot = new ChatbotEngine(memory, taskManager, quizManager, logger);

            AudioPlayer.PlayGreeting();

            logger.Add("Application started");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (string.IsNullOrWhiteSpace(input))
                return;

            lstChat.Items.Add("You: " + input);

            string response = chatbot.ProcessInput(input);

            lstChat.Items.Add("Bot: " + response);

            txtInput.Clear();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;

            if (string.IsNullOrWhiteSpace(title))
                return;

            TaskItem task = new TaskItem
            {
                Title = title,
                Description = txtTaskDesc.Text,
                ReminderDate = dtReminder.Value,
                Completed = false
            };

            taskManager.AddTask(task);

            lstTasks.Items.Add(title);

            logger.Add("Task added via GUI: " + title);

            MessageBox.Show("Task added successfully!");
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            lstTasks.Items.Clear();

            foreach (var task in taskManager.GetTasks())
            {
                lstTasks.Items.Add(task.Title + " | " +
                    (task.Completed ? "Done" : "Pending"));
            }

            logger.Add("Tasks loaded from database");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
                return;

            var tasks = taskManager.GetTasks();

            int id = tasks[lstTasks.SelectedIndex].TaskID;

            taskManager.DeleteTask(id);

            logger.Add("Task deleted");

            btnLoadTasks_Click(sender, e);
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            quizManager = new QuizManager();

            lstQuiz.Items.Clear();

            LoadQuizQuestion();

            logger.Add("Quiz started");
        }

        private void LoadQuizQuestion()
        {
            if (quizManager.QuizFinished())
            {
                lstQuiz.Items.Add("Final Score: " + quizManager.Score);
                lstQuiz.Items.Add(quizManager.GetFinalFeedback());

                logger.Add("Quiz completed");

                return;
            }

            var q = quizManager.GetCurrentQuestion();

            lstQuiz.Items.Clear();

            lstQuiz.Items.Add(q.Question);

            for (int i = 0; i < q.Options.Count; i++)
            {
                lstQuiz.Items.Add($"{i}. {q.Options[i]}");
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnswer.Text, out int answer))
                return;

            bool correct = quizManager.SubmitAnswer(answer);

            if (correct)
                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Wrong!");

            LoadQuizQuestion();

            logger.Add("Quiz answer submitted");
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();

            foreach (var log in logger.GetRecentLogs())
            {
                lstLog.Items.Add(log.TimeStamp + " - " + log.Action);
            }
        }
    }
}
