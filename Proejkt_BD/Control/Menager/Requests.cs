using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proejkt_BD.Control.Baza;

namespace Proejkt_BD.Control.Menager
{
    public partial class Requests : UserControl
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var obj = SQLmanager.SearchObjects3(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
            var customer = SQLmanager.SearchCustomerFromID(obj.First().id_client.ToString());
            string customer2 = customer.First().first_name.ToString() + " " + customer.First().last_name.ToString() + " " + customer.First().name.ToString();
            RequestDetails a1 = new RequestDetails();
            a1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //id
            a1.richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //description

            if (this.dataGridView1.CurrentRow.Cells[3].Value == null)
                a1.richTextBox2.Text = "";
            else
                a1.richTextBox2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //result


            a1.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //status
            a1.textBox2.Text = customer2; //customer data
            a1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString(); //vehicle data            
            a1.dateTimePicker1.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[4].Value.ToString()); //start date

            if (this.dataGridView1.CurrentRow.Cells[5].Value == null)
                a1.richTextBox2.Text = "";
            else                
                a1.dateTimePicker2.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[5].Value.ToString()); //final date
            
            a1.ShowDialog();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            string d;
            if (dateTimePicker2.Checked == true)
                d = dateTimePicker2.Text.ToString();
            else
                d = "";

            var request = SQLmanager.SearchRequests(comboBox1.Text.ToString(), d, objectBox.Text.ToString());
            dataGridView1.DataSource = request;
        }

        private void Requests_Load(object sender, EventArgs e)
        {            
            var result = SQLmanager.SearchRequests("", "", "");
            dataGridView1.DataSource = result;
        }
    }
}
