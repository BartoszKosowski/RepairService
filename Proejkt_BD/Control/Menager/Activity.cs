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

namespace Proejkt_BD.Control.Menager
{
    public partial class Activity : Form
    {
        public int _id_act;
        public int _id_req;
        public int _seqNumber;
        //public string _actDic;
        public Activity(int act_id, int req_id, int seqNumber, string actDic, string desc, string status, DateTime dreg, DateTime dfc)
        {
            InitializeComponent();
            _id_act = act_id;
            _id_req = req_id;
            _seqNumber = seqNumber;
            //_actDic = actDic;
            textBox3.Text = _id_act.ToString();
            textBox3.Enabled = false;
            textBox1.Text = _id_req.ToString();
            textBox1.Enabled = false;
            textBox5.Text = _seqNumber.ToString();
            textBox5.Enabled = false;
            
            var act_type = SQLmanager.SearchActivityDictionaryType(actDic);
            textBox2.Text=act_type.First().ToString();
            //textBox4.Text = result;
            richTextBox1.Text = desc;
            dateTimePicker1.Value = dfc; //data fin/can
            dateTimePicker2.Value = dreg; //data rejestracji

            //comboBox1.DataSource = Baza.SQLmanager.GetAvailableActivity().ToList();
            comboBox2.DataSource = Baza.SQLmanager.GetAvailableWorkers().ToList();


            var dataSource = new List<string>();
            if (status == "ACT")
            {
                dataSource.Add("ACT");
                dataSource.Add("CAN");
                dataSource.Add("EXP");
            }
            else if (status == "CAN")
            {
                dataSource.Add("CAN");
                dataSource.Add("ACT");
                dataSource.Add("EXP");

            }
            else
            {
                dataSource.Add("EXP");
                dataSource.Add("ACT");
                dataSource.Add("CAN");
            }

            comboBox1.DataSource = dataSource;

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var act = SQLmanager.SearchActivityDictionary(textBox2.Text);
            string act_ = act.First().ToString();
            Baza.SQLmanager.UpdateActivity(_id_act, _seqNumber, richTextBox1.Text, comboBox2.SelectedItem.ToString(), comboBox1.Text, dateTimePicker2.Value, dateTimePicker1.Value, act_);
            MessageBox.Show("The activity has been updated");
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Activity_Load(object sender, EventArgs e)
        {

        }
    }
}
