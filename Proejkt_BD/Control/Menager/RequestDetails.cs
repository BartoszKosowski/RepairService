using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proejkt_BD.Control.Baza;

namespace Proejkt_BD.Control.Menager
{
    public partial class RequestDetails : Form
    {
        public RequestDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activity a1 = new Activity(Int32.Parse(textBox1.Text), Int32.Parse(this.dataGridView1.CurrentRow.Cells[9].Value.ToString()), 
                this.dataGridView1.CurrentRow.Cells[8].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            a1.ShowDialog();

            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;

        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.ACTIVITY' . Możesz go przenieść lub usunąć.
            //this.aCTIVITYTableAdapter.Fill(this.rSSDataSet.ACTIVITY);
            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.SaveRequestDetails(Int32.Parse(textBox1.Text), richTextBox1.Text/*, comboBox1.SelectedValue*/, richTextBox2.Text, dateTimePicker1.Value);
            MessageBox.Show("The changes has been saved");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddActivity add = new AddActivity(Int32.Parse(textBox1.Text), dateTimePicker2.Value, dateTimePicker1.Value);
            add.Show();

            /*dataGridView1.Update();
            dataGridView1.Refresh();
            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;
        }
    }
}
