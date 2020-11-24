using System;
using Proejkt_BD.Control.Admin;
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
            MessageBox.Show("Goodbye!");
            Form1 a1 = new Form1();
            a1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser a1 = new NewUser();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditUser a1 = new EditUser();
            a1.textBox5.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //id
            a1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //fname
            a1.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //lname
            a1.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //role
            a1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString(); //login
            a1.textBox4.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString(); //password
            
            string check = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); //active
            if (check == "T")
            {
                a1.checkBox1.Text = "Konto jest aktywne";
                a1.checkBox1.Checked = true;
            }
            else
            {
                a1.checkBox1.Text = "Konto jest zablokowane";
                a1.checkBox1.Checked = false;
            }
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
            {
                if (checkBox2.Checked)
                    a = "A";
                else
                    a = "T";
            }

            else if (checkBox2.Checked)
            {
                if (checkBox1.Checked)
                    a = "A";
                else
                    a = "F";
            }

            else
                a = "A";

            var result = SQL.SearchAdmin(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), comboBox1.Text.ToString(), a);
            dataGridView1.DataSource = result;
         }
    }
}
