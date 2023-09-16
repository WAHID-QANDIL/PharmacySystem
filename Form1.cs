using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.SqlServer.Server;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;

namespace PharmacyProjectITI
{
    public partial class Form1 : Form
    {
        private pharmacyContext dadabase = new pharmacyContext();

        ~Form1()
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();

            string name = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox4.Text;
            string copassword = textBox3.Text;

            if (name == "")
            {
                MessageBox.Show("You have to enter your name first:");
            }
            else if (password == "")
            {
                MessageBox.Show("You have to enter your password first:");
            }
            else if (email == "")
            {
                MessageBox.Show("You have to enter your email first:");
            }
            else if (copassword != password)
            {
                MessageBox.Show("You have to confirm your password first:");
            }
            else
            {
                var idList = dadabase.user.Select(s => s.uEmail).ToList();
                bool isexist = false;

                foreach (var item in idList)
                {
                    if (item == textBox4.Text)
                    {
                        isexist = true;
                        break;
                    }
                }
                if (isexist)
                {
                    MessageBox.Show("User alrady exists:");
                    textBox4.Text = "";
                }
                else
                {
                    user.uName = name;
                    user.uEmail = email;
                    user.uPassword = password;
                    dadabase.Add(user);
                    dadabase.SaveChanges();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("User Added succesfuly: \n Now you can login");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            //this.Close();
            loginPage.Show();
        }
    }
}