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
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddCustomer a1 = new AddCustomer();
            a1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCustomerDetails a1 = new EditCustomerDetails();
            a1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCustomerDetails a1 = new ShowCustomerDetails();
            a1.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
