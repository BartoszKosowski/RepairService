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

            var result = SQLworker.SearchActivity(comboBox1.Text.ToString(), d, check);
            dataGridView1.DataSource = result;
        }
    }
}
