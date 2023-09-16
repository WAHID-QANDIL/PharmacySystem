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
    public partial class Pharmacy_Mediciens : Form
    {
        private pharmacyContext dadabase = new pharmacyContext();

        public Pharmacy_Mediciens()
        {
            InitializeComponent();
        }

        private void Pharmacy_Mediciens_Load(object sender, EventArgs e)
        {
            var data = dadabase.medicien.Select(s => new { s.mid_name, s.mid_price, s.productionDate, s.expireDate, s.Categary, s.quantity }).ToList();
            dataGridView1.DataSource = data;

            dataGridView2.DataSource = data.Where(s => s.expireDate < DateTime.Now || s.quantity <= 0).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var data = dadabase.medicien.Select(s => new { s.mid_name, s.mid_price, s.productionDate, s.expireDate, s.Categary, s.quantity }).ToList();
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dadabase.medicien.Select(s => new { s.mid_name, s.mid_price, s.productionDate, s.expireDate, s.Categary, s.quantity }).Where(a => a.mid_name.StartsWith(textBox1.Text)).ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetOrder getOrder = new GetOrder();
            this.Hide();
            getOrder.Show();
        }
    }
}