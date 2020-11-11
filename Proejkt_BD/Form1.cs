using Proejkt_BD.Control.Admin;
using Proejkt_BD.Control.Menager;
using Proejkt_BD.Control.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login and password correct");
            this.Hide();
            AdminPanel a1 = new AdminPanel();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login and password correct");
            this.Hide();
            MainManager a1 = new MainManager();
            a1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login and password correct");
            this.Hide();
            WorkerPanel a1 = new WorkerPanel();
            a1.ShowDialog();
        }
    }
}
