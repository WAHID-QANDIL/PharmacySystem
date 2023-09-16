namespace PharmacyProjectITI
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            Passlab = new Label();
            UserNamelab = new Label();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(335, 310);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 22;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(563, 117);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 21;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Passlab
            // 
            Passlab.AutoSize = true;
            Passlab.Location = new Point(205, 242);
            Passlab.Name = "Passlab";
            Passlab.Size = new Size(64, 17);
            Passlab.TabIndex = 16;
            Passlab.Tag = "";
            Passlab.Text = "Password";
            // 
            // UserNamelab
            // 
            UserNamelab.AutoSize = true;
            UserNamelab.Location = new Point(230, 186);
            UserNamelab.Name = "UserNamelab";
            UserNamelab.Size = new Size(39, 17);
            UserNamelab.TabIndex = 15;
            UserNamelab.Text = "Email";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveBorder;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            richTextBox1.Location = new Point(199, 36);
            richTextBox1.Margin = new Padding(10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(326, 106);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "Pharmacy Login Page";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 25);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 25);
            textBox1.TabIndex = 12;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(755, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Passlab);
            Controls.Add(UserNamelab);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label Passlab;
        private Label UserNamelab;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}