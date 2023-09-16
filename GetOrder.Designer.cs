namespace PharmacyProjectITI
{
    partial class GetOrder
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
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(630, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveBorder;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            richTextBox1.Location = new Point(188, 19);
            richTextBox1.Margin = new Padding(10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(374, 60);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "Orders page take one now";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(630, 178);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 25);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 125);
            label1.Name = "label1";
            label1.Size = new Size(90, 17);
            label1.TabIndex = 17;
            label1.Text = "Medicin name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 186);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 18;
            label2.Text = "Medicien quantity";
            // 
            // button1
            // 
            button1.Location = new Point(654, 324);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 19;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 25);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 283);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 246);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(630, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 25);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // GetOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Name = "GetOrder";
            Load += GetOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
    }
}