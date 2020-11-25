using Proejkt_BD.Control.Admin;
using Proejkt_BD.Control.Menager;
using Proejkt_BD.Control.Worker;
using Proejkt_BD.Control.Baza;
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

        private void button4_Click(object sender, EventArgs e)
        {
            var result = SQL.CheckLog(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (result.Any())
            {
                this.Controls.Clear();

                if (result.First().role.ToString() == "Admin")
                {
                    MessageBox.Show("Login and password correct");
                    this.Hide();
                    AdminPanel a1 = new AdminPanel();
                    a1.ShowDialog();
                    //this.Controls.Add(new AdminPanel());
                }
                if (result.First().role.ToString() == "Manager")
                {
                    MessageBox.Show("Login and password correct");
                    this.Hide();
                    MainManager a1 = new MainManager();
                    a1.textBox1.Text = result.First().id_personel.ToString();
                    a1.ShowDialog();

                }
                if (result.First().role.ToString() == "Worker")
                {
                    MessageBox.Show("Login and password correct");
                    this.Hide();
                    WorkerPanel a1 = new WorkerPanel();
                    a1.textBox1.Text = result.First().id_personel.ToString();
                    a1.ShowDialog();
                }                
            }
            else
                MessageBox.Show("Login and password incorrect");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
