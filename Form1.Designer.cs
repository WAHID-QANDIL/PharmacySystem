namespace PharmacyProjectITI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            Passlab = new Label();
            UserNamelab = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 25);
            textBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveBorder;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            richTextBox1.Location = new Point(190, 19);
            richTextBox1.Margin = new Padding(10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(326, 106);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "Pharmacy Registration";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Passlab
            // 
            Passlab.AutoSize = true;
            Passlab.Location = new Point(196, 276);
            Passlab.Name = "Passlab";
            Passlab.Size = new Size(64, 17);
            Passlab.TabIndex = 5;
            Passlab.Tag = "";
            Passlab.Text = "Password";
            // 
            // UserNamelab
            // 
            UserNamelab.AutoSize = true;
            UserNamelab.Location = new Point(190, 169);
            UserNamelab.Name = "UserNamelab";
            UserNamelab.Size = new Size(70, 17);
            UserNamelab.TabIndex = 4;
            UserNamelab.Text = "UserName";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 25);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 324);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 7;
            label1.Tag = "";
            label1.Text = "Confirm Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 25);
            textBox4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 225);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 9;
            label2.Tag = "";
            label2.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(330, 373);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 100);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 11;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(Passlab);
            Controls.Add(UserNamelab);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label Passlab;
        private Label UserNamelab;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}