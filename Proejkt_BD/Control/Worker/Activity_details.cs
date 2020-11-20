using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejkt_BD.Control.Worker
{
    public partial class Activity_details : Form
    {
        public Activity_details()
        {
            InitializeComponent();
        }

        public Activity_details(int _id, string _mode) : base()
        {
            id = _id;
            mode = _mode;
        }
        private int id;
        private string mode;
        private void Activity_details_Load(object sender, EventArgs e)
        {
        MessageBox.Show(mode);
        }
    }
}
