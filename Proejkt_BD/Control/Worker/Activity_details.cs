using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proejkt_BD.Control.Baza;

namespace Proejkt_BD.Control.Worker
{
    public partial class Activity_details : Form
    {
        public Activity_details()
        {
            InitializeComponent();
        }

        //public Activity_details(object sender, EventArgs e)
        //{

        //}
        private void Activity_details_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLworker.EditActivity(textBox3.Text.ToString(), dateTimePicker1.Value, comboBox1.Text.ToString(), richTextBox2.Text.ToString());
            this.Close();
        }
    }
}
