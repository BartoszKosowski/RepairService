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
    public partial class NewRequest2 : Form
    {
        public NewRequest2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewRequest3 a1 = new NewRequest3();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVehicle a1 = new AddVehicle();
            a1.ShowDialog();
        }
    }
}
