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
    public partial class SearchActivity : Form
    {
        public SearchActivity(string id)
        {
            InitializeComponent();
            var result = Baza.SQLmanager.SearchActivity(id);
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
