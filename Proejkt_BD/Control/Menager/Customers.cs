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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddCustomer a1 = new AddCustomer();
            a1.ShowDialog();
            UsersDataLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCustomerDetails a1 = new EditCustomerDetails();
            a1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCustomerDetails a1 = new ShowCustomerDetails();
            a1.textBox5.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //id
            a1.textBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //fname
            a1.textBox2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); //lname
            a1.textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //name
            a1.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); //tel
            a1.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rSSDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchCustomers(nameBox.Text.ToString(), fnameBox.Text.ToString(), textBox1.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLmanager.DeleteCustomer(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()); //id
            UsersDataLoad();

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            UsersDataLoad();
        }

        private void UsersDataLoad(string name = "", string fname="", string lname="" )
        {
            var result = SQLmanager.SearchCustomers(name, fname, lname);
            dataGridView1.DataSource = result;
        }
    }
}
