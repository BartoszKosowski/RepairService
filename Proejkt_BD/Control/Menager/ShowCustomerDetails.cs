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
    public partial class ShowCustomerDetails : Form
    {
        public ShowCustomerDetails()
        {
            InitializeComponent();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    AddVehicle a1 = new AddVehicle();
        //    a1.ShowDialog();
        //}

        private void ShowCustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.OBJECT' . Możesz go przenieść lub usunąć.
            //this.oBJECTTableAdapter.Fill(this.rSSDataSet.OBJECT);
            var result = SQLmanager.SearchObjects2(this.textBox5.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
