using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Menager
{
    public partial class Requests : UserControl
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewRequest a1 = new NewRequest();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RequestDetails a1 = new RequestDetails();
            a1.ShowDialog();
        }
    }
}
