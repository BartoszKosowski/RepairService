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
    }
}
