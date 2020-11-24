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
    public partial class Vehicle : UserControl
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchObjects(textBox4.Text.ToString(), textBox3.Text.ToString(), textBox2.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            var result = SQLmanager.SearchObjects("", "", "");
            dataGridView1.DataSource = result;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = SQLmanager.SearchClient(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            var type = SQLmanager.SearchObjType(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            
            VehicleDetails a1 = new VehicleDetails();
            a1.textBox6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); //reg            
            a1.textBox10.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); //name
            a1.textBox9.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString(); //obj type
            
            a1.textBox8.Text = type.First().name;  //obj name
            a1.textBox5.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); ; //client id
            a1.textBox1.Text = client.First().first_name; //fname
            a1.textBox2.Text = client.First().last_name; //lname
            a1.textBox3.Text = client.First().name; ; //name
            a1.textBox4.Text = client.First().tel; ; //tel
            
            

            a1.ShowDialog();
        }
    }
}
