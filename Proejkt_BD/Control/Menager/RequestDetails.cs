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
        string _status;
        public RequestDetails(string status)
        {
            InitializeComponent();
            _status = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.CurrentRow == null )
            {
                MessageBox.Show("The chosen activity does not exist, please create new avtivity or choose another");

                var result1 = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
                dataGridView1.DataSource = result1;

            }
            else
            {
                Activity a1 = new Activity(Int32.Parse(textBox1.Text), Int32.Parse(this.dataGridView1.CurrentRow.Cells[9].Value.ToString()),
                this.dataGridView1.CurrentRow.Cells[8].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                a1.ShowDialog();
            }
            

            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;

        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.ACTIVITY' . Możesz go przenieść lub usunąć.
            //this.aCTIVITYTableAdapter.Fill(this.rSSDataSet.ACTIVITY);
            var dataSource = new List<string>();
            
            if (_status == "ACT")
            {
                dataSource.Add("ACT");
                dataSource.Add("CAN");
                dataSource.Add("EXP");
            } 
            
            else if (_status == "CAN")
            {
                dataSource.Add("CAN");
                dataSource.Add("ACT");
                dataSource.Add("EXP");
            }
            
            else
            {
                dataSource.Add("EXP");
                dataSource.Add("ACT");
                dataSource.Add("CAN");
            }
            

            comboBox1.DataSource = dataSource;
            

            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.SaveRequestDetails(Int32.Parse(textBox1.Text), richTextBox1.Text, comboBox1.Text, richTextBox2.Text, dateTimePicker1.Value);
            MessageBox.Show("The changes has been saved");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddActivity add = new AddActivity(Int32.Parse(textBox1.Text), dateTimePicker2.Value, dateTimePicker1.Value);
            add.Show();

            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;

            var result1 = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result1;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
