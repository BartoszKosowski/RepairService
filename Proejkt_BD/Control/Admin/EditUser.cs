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

namespace Proejkt_BD.Control.Admin
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

          private void button1_Click(object sender, EventArgs e)
            {
                string check;
                if (checkBox1.Checked)
                    check = "T";
                else
                    check = "F";
                SQL.EditPersonel(textBox5.Text.ToString(), textBox1.Text.ToString(), textBox2.Text.ToString(), textBox4.Text.ToString(), check);
                //this.Hide();
                //MessageBox.Show("User updated successfully");
                this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
