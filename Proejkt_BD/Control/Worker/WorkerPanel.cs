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

namespace Proejkt_BD.Control.Worker
{
    public partial class WorkerPanel : Form
    {
        public WorkerPanel()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a1 = new Form1();
            a1.ShowDialog();
            //Baza.SQLworker.SetWorkerInactive(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Activity_details a1 = new Activity_details();       
            a1.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void WorkerPanel_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.ACTIVITY' . Możesz go przenieść lub usunąć.
            this.aCTIVITYTableAdapter.Fill(this.rSSDataSet.ACTIVITY);

            var dataSource = new List<string>();
            dataSource.Add("ALL");
            dataSource.Add("ACT");
            dataSource.Add("CAN");
            dataSource.Add("EXP");

            comboBox1.DataSource = dataSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check;
            if (checkBox1.Checked == true)
                check = textBox1.Text.ToString();
            else
                check = "";


            string d;
            if (dateTimePicker2.Checked == true)
                d = dateTimePicker2.Text.ToString();
            else
                d = "";

            if (comboBox1.Text == "ALL")
            {
                var result = SQLworker.SearchActivity("", d, check);
                dataGridView1.DataSource = result;
            }
            else
            {
                var result = SQLworker.SearchActivity(comboBox1.Text.ToString(), d, check);
                dataGridView1.DataSource = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Activity_details a1 = new Activity_details();
            a1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //request id
            a1.textBox3.Enabled = false;

            a1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString(); //request id
            a1.textBox1.Enabled = false;

            a1.textBox2.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString(); //sequence number
            a1.textBox2.Enabled = false;

            if (this.dataGridView1.CurrentRow.Cells[4].Value == null) //date reg
            {
                a1.dateTimePicker2.Text = "00-00-0000";
            }
            else
            {
                a1.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); //date of reg
            }
            a1.dateTimePicker2.Enabled = false;

            a1.textBox4.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString(); //activity dictionary
            a1.textBox4.Enabled = false;

            a1.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //status
            a1.comboBox1.Enabled = false;

            a1.richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //description
            a1.richTextBox1.Enabled = false;

            if (this.dataGridView1.CurrentRow.Cells[3].Value == null)
                a1.richTextBox2.Text = "";
            else
                a1.richTextBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //result
            a1.richTextBox2.Enabled = false;

            if (this.dataGridView1.CurrentRow.Cells[5].Value == null) //date f/c
            {
                a1.dateTimePicker1.Text = "00-00-0000";
            }
            else
            {
                a1.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString(); //date f/c
            }
            a1.dateTimePicker1.Enabled = false;
            
            a1.button1.Enabled = false;
            a1.button1.Visible = false;

            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Activity_details a1 = new Activity_details();
            a1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //request id
            a1.textBox3.Enabled = false;

            a1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString(); //request id
            a1.textBox1.Enabled = false;

            a1.textBox2.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString(); //sequence number
            a1.textBox2.Enabled = false;

            if (this.dataGridView1.CurrentRow.Cells[4].Value == null) //date reg
            {
                var date1 = new DateTime(0000, 0, 0, 0, 00, 00);
                a1.dateTimePicker2.Value = date1;
            }
            else
            {
                a1.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            a1.dateTimePicker2.Enabled = false;

            a1.textBox4.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString(); //activity dictionary
            a1.textBox4.Enabled = false;

            a1.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //status
            a1.comboBox1.Enabled = true;

            a1.richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //description
            a1.richTextBox1.Enabled = false;

            if (this.dataGridView1.CurrentRow.Cells[2].Value == null)
                a1.richTextBox2.Text = "";
            else
                a1.richTextBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //result
            a1.richTextBox2.Enabled = true;

            if (this.dataGridView1.CurrentRow.Cells[5].Value == null) //date f/c
            {
                var date1 = new DateTime(0000, 0, 0, 0, 00, 00);
                a1.dateTimePicker1.Value = date1;
            }
            else
            {
                a1.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            a1.dateTimePicker1.Enabled = true;

            a1.button1.Enabled = true;
            a1.button1.Visible = true;

            a1.ShowDialog();
            this.aCTIVITYTableAdapter.Fill(this.rSSDataSet.ACTIVITY);
        }
    }
}
