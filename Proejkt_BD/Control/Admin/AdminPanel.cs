using System;
using Proejkt_BD.Control.Baza;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a1 = new Form1();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser a1 = new NewUser();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditUser a1 = new EditUser();
            a1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.PERSONEL' . Możesz go przenieść lub usunąć.
            this.pERSONELTableAdapter.Fill(this.rSSDataSet.PERSONEL);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            if (checkBox1.Checked)
                a = "T";
            else 
                a = "F";

            var result = SQL.SearchAdmin(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), comboBox1.Text.ToString(), a);
            dataGridView1.DataSource = result;
         }
    }
}
