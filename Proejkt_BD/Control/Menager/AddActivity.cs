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
        Int32 _id;
        DateTime _reqDate, _exDate;
        public AddActivity(Int32 id, DateTime reqDate, DateTime exDate)
        {
            InitializeComponent();
            _id = id;
            _exDate = exDate;
            _reqDate = reqDate;

            comboBox1.DataSource = Baza.SQLmanager.GetAvailableActivity().ToList();
            textBox5.Text = Baza.SQLmanager.GetActivityNumber(_id).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baza.SQLmanager.AddActivity(_id, Int16.Parse(textBox5.Text), comboBox1.Text, richTextBox1.Text, _reqDate, _exDate);
            Close();
        }

        private void AddActivity_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
