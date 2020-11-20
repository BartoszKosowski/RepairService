using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Worker
{
    public partial class WorkerPanel : Form
    {
        public WorkerPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a1 = new Form1();
            a1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Activity_details a1 = new Activity_details(1,"read_mode");
        
            a1.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
