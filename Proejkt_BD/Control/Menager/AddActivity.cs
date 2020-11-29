using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Menager
{
    public partial class AddActivity : Form
    {
        public int _id;
        public AddActivity(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.AddActivity(_id, Int16.Parse(textBox5.Text), comboBox1.Text, richTextBox1.Text);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
