namespace PharmacyProjectITI
{
    partial class Pharmacy_Mediciens
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            name = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(703, 201);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(656, 58);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 37;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(542, 58);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 36;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(439, 25);
            name.Name = "name";
            name.Size = new Size(97, 17);
            name.TabIndex = 35;
            name.Tag = "";
            name.Text = "Medicien name";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ActiveBorder;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            richTextBox1.Location = new Point(36, 6);
            richTextBox1.Margin = new Padding(10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(371, 93);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "Pharmacy Medicines Page";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 25);
            textBox1.TabIndex = 31;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 418);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(703, 201);
            dataGridView2.TabIndex = 39;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ActiveBorder;
            richTextBox2.Cursor = Cursors.Hand;
            richTextBox2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            richTextBox2.Location = new Point(36, 365);
            richTextBox2.Margin = new Padding(10);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.RightToLeft = RightToLeft.Yes;
            richTextBox2.Size = new Size(323, 53);
            richTextBox2.TabIndex = 40;
            richTextBox2.Text = "Expired or not avilable";
            // 
            // button3
            // 
            button3.Location = new Point(439, 58);
            button3.Name = "button3";
            button3.Size = new Size(83, 25);
            button3.TabIndex = 41;
            button3.Text = "Get order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Pharmacy_Mediciens
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(775, 648);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(name);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Name = "Pharmacy_Mediciens";
            Text = "Pharmacy_Mediciens";
            Load += Pharmacy_Mediciens_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Label name;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private RichTextBox richTextBox2;
        private Button button3;
    }
}