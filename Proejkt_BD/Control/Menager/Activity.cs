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
    public partial class Activity : Form
    {
        public int _id;
        public int _seqNumber;
        //public string _actDic;
        public Activity(int id, int seqNumber, string actDic, string desc)
        {
            InitializeComponent();
            _id = id;
            _seqNumber = seqNumber;
            //_actDic = actDic;
            textBox1.Text = _id.ToString();
            textBox5.Text = _seqNumber.ToString();
            textBox2.Text = actDic;
            //textBox4.Text = result;
            richTextBox1.Text = desc;
            //comboBox1.DataSource = Baza.SQLmanager.GetAvailableActivity().ToList();
            comboBox2.DataSource = Baza.SQLmanager.GetAvailableWorkers().ToList();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.UpdateActivity(_id, _seqNumber, richTextBox1.Text, comboBox2.SelectedValue.ToString(), comboBox3.SelectedValue.ToString());
            MessageBox.Show("The activity has been updated");
            
            this.Close();
        }
    }
}
