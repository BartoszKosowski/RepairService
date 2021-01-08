//using Proejkt_BD.Control.Admin;
using Proejkt_BD.Control.Menager;
//using Proejkt_BD.Control.Worker;
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
    public partial class MainManager : Form
    {
        public MainManager()
        {
            InitializeComponent();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Requests());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a1 = new Form1();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Requests());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Customers());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NewRequest a1 = new NewRequest();
            Baza.SQLmanager.CreateEmptyRequest();
            var a1 = new NeuRequest(textBox1.Text);
            a1.ShowDialog();
            Baza.SQLmanager.RefreshRequest();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Requests());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Vehicle());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
