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
    public partial class GetOrder : Form
    {
        private pharmacyContext pharmacyContext = new pharmacyContext();

        public GetOrder()
        {
            InitializeComponent();
        }

        private void GetOrder_Load(object sender, EventArgs e)
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBox1.DataSource = pharmacyContext.medicien.Select(s => s.mid_name).ToList();
            comboBox2.DataSource = ints;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = pharmacyContext.user.Select(s => new { s.uEmail, s.uPassword }).ToList();
            bool exist = false;
            foreach (var item in email)
            {
                if (item.uEmail == textBox2.Text && item.uPassword == textBox1.Text)
                {
                    exist = true; break;
                }
            }
            var userIDs_e = pharmacyContext.user.Select(s => new { s.id, s.uEmail }).ToList();
            var midID = pharmacyContext.medicien.Select(s => s.mid_id).ToList();
            if (exist)
            {
                User_mediciens user_Mediciens = new User_mediciens();
                user_Mediciens.mid_name = Convert.ToString(comboBox1.SelectedValue);
                user_Mediciens.quantity = Convert.ToInt32(comboBox2.SelectedValue);
                user_Mediciens.Name = Convert.ToString(comboBox1.SelectedValue);
                user_Mediciens.mid_id = Convert.ToInt32(midID.Select(s => s == 1).SingleOrDefault());
                pharmacyContext.Add(user_Mediciens);
                pharmacyContext.SaveChanges();
                MessageBox.Show("Order recived \n Thanks for using our services");
            }
            else
            {
                MessageBox.Show("Invalid user email or password");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}