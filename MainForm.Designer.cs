namespace CybersecurityAwarenessBot
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;

        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.DateTimePicker dtReminder;

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnLoadTasks;
        private System.Windows.Forms.Button btnDeleteTask;

        private System.Windows.Forms.ListBox lstTasks;

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ListBox lstQuiz;

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnShowLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstChat = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();

            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();

            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();

            this.lstTasks = new System.Windows.Forms.ListBox();

            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lstQuiz = new System.Windows.Forms.ListBox();

            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnShowLog = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // CHAT
            this.lstChat.Location = new System.Drawing.Point(20, 20);
            this.lstChat.Size = new System.Drawing.Size(350, 200);

            this.txtInput.Location = new System.Drawing.Point(20, 230);
            this.txtInput.Size = new System.Drawing.Size(250, 20);

            this.btnSend.Text = "Send";
            this.btnSend.Location = new System.Drawing.Point(280, 228);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // TASKS
            this.txtTaskTitle.Location = new System.Drawing.Point(400, 20);
            this.txtTaskTitle.PlaceholderText = "Task Title";

            this.txtTaskDesc.Location = new System.Drawing.Point(400, 50);
            this.txtTaskDesc.PlaceholderText = "Description";

            this.dtReminder.Location = new System.Drawing.Point(400, 80);

            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Location = new System.Drawing.Point(400, 110);
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            this.btnLoadTasks.Text = "Load Tasks";
            this.btnLoadTasks.Location = new System.Drawing.Point(500, 110);
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);

            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.Location = new System.Drawing.Point(600, 110);
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);

            this.lstTasks.Location = new System.Drawing.Point(400, 150);
            this.lstTasks.Size = new System.Drawing.Size(200, 120);

            // QUIZ
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.Location = new System.Drawing.Point(20, 270);
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);

            this.lstQuiz.Location = new System.Drawing.Point(20, 300);
            this.lstQuiz.Size = new System.Drawing.Size(350, 120);

            this.txtAnswer.Location = new System.Drawing.Point(20, 430);

            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.Location = new System.Drawing.Point(150, 428);
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);

            // LOG
            this.btnShowLog.Text = "Show Log";
            this.btnShowLog.Location = new System.Drawing.Point(400, 300);
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);

            this.lstLog.Location = new System.Drawing.Point(400, 330);
            this.lstLog.Size = new System.Drawing.Size(300, 150);

            // FORM
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSend);

            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.txtTaskDesc);
            this.Controls.Add(this.dtReminder);

            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.btnDeleteTask);

            this.Controls.Add(this.lstTasks);

            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.lstQuiz);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnSubmitAnswer);

            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnShowLog);

            this.Text = "Cybersecurity Awareness Bot";

            this.ResumeLayout(false);
        }
    }
}
