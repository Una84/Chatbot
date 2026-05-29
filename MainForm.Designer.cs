namespace CybersecurityAwarenessBot
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Text = "Cybersecurity Awareness Bot";

            // chatBox
            this.chatBox.Location = new System.Drawing.Point(30, 70);
            this.chatBox.Size = new System.Drawing.Size(500, 300);
            this.chatBox.BackColor = System.Drawing.Color.Black;
            this.chatBox.ForeColor = System.Drawing.Color.Lime;
            this.chatBox.Font = new System.Drawing.Font("Consolas", 10);

            // txtUserInput
            this.txtUserInput.Location = new System.Drawing.Point(30, 390);
            this.txtUserInput.Size = new System.Drawing.Size(380, 23);

            // btnSend
            this.btnSend.Location = new System.Drawing.Point(430, 388);
            this.btnSend.Size = new System.Drawing.Size(100, 30);
            this.btnSend.Text = "Send";
            this.btnSend.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(570, 450);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnSend);

            this.Text = "Cybersecurity Awareness Bot";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
