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
using Proejkt_BD.Control.Worker;

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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id_act = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int id_req = Int32.Parse(this.dataGridView1.CurrentRow.Cells[6].Value.ToString());
            int seq_nb = Int32.Parse(this.dataGridView1.CurrentRow.Cells[9].Value.ToString());
            string actDict = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string desc = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string status = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DateTime dreg = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            DateTime dfc = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            
            Activity a1 = new Activity(id_act, id_req, seq_nb, actDict, desc, status, dreg, dfc);
            a1.ShowDialog();
        }

        private void SearchActivity_Load(object sender, EventArgs e)
        {

        }
    }
}
