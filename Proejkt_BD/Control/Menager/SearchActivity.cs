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
            this.dataGridView1.Columns["result"].Visible = false;
            this.dataGridView1.Columns["id_personel"].Visible = false;
            this.dataGridView1.Columns["ACT_DICT1"].Visible = false;
            this.dataGridView1.Columns["PERSONEL"].Visible = false;
            this.dataGridView1.Columns["REQUEST"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
