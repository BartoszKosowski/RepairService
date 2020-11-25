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
    public partial class RequestDetails : Form
    {
        public RequestDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activity a1 = new Activity();
            a1.ShowDialog();
        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.ACTIVITY' . Możesz go przenieść lub usunąć.
            //this.aCTIVITYTableAdapter.Fill(this.rSSDataSet.ACTIVITY);
            var result = SQLmanager.SearchActivity(this.textBox1.Text.ToString());
            dataGridView1.DataSource = result;
        }
    }
}
