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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();

            var dataSource = new List<string>();
            dataSource.Add("Admin");
            dataSource.Add("Manager");
            dataSource.Add("Worker");

            comboBox1.DataSource = dataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check;
            if (checkBox1.Checked)
                check = "T";
            else
                check = "F";
            SQLadmin.AddPersonel(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), comboBox1.Text.ToString(), textBox4.Text.ToString(), check);           
            MessageBox.Show("New user added successfully");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
