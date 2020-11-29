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
    public partial class SearchCustomer : Form
    {
        public IQueryable<Baza.CLIENT> _cl;
        public SearchCustomer()
        {
            InitializeComponent();
            var result = Baza.SQLmanager.SearchCustomers("", "", "");
            dataGridView1.DataSource = result;
        }
        public void SetClient(IQueryable<Baza.CLIENT> cl) => _cl = cl;

        public IQueryable<Baza.CLIENT> GetClient() => _cl;


        private void searchBox_Click(object sender, EventArgs e)
        {
            var result = Baza.SQLmanager.SearchCustomers(nameBox.Text.ToString(), fnameBox.Text.ToString(), textBox1.Text.ToString());
            dataGridView1.DataSource = result;
            //SetClient(result);
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            var ac = new AddCustomer();
            ac.ShowDialog();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            var result = Baza.SQLmanager.ChooseCustomer(this.dataGridView1.CurrentRow.Cells[0].Value);
            SetClient(result);
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
