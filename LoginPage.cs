using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProjectITI
{
    public partial class LoginPage : Form
    {
        private pharmacyContext dadabase = new pharmacyContext();

        ~LoginPage()
        {
            Application.Exit();
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var emails = dadabase.user.Select(s => new { s.uEmail, s.uPassword }).ToList();
            bool isExists = false;
            foreach (var item in emails)
            {
                if (textBox1.Text == item.uEmail && textBox2.Text == item.uPassword)
                {
                    isExists = true;
                    break;
                }
            }
            if (isExists)
            {
                Pharmacy_Mediciens pharmacy_Mediciens = new Pharmacy_Mediciens();
                MessageBox.Show("You are logined now!");
                this.Hide();
                pharmacy_Mediciens.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password or email");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }
    }
}