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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.OBJECT' . Możesz go przenieść lub usunąć.
            //this.oBJECTTableAdapter.Fill(this.rSSDataSet.OBJECT);
            
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'rSSDataSet.OBJ_TYPE' . Możesz go przenieść lub usunąć.
            //this.oBJ_TYPETableAdapter.Fill(this.rSSDataSet.OBJ_TYPE);
            
            var result0 = Baza.SQLmanager.SearchCustomers("xxxxx", "", "");
            dataGridView1.DataSource = result0;

            var types = SQLmanager.GetAllObjectTypes().ToList();
            comboBox1.DataSource = types;

            var clients = SQLmanager.GetAllClients().ToList();
            //comboBox2.DataSource = clients;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int.TryParse(comboBox2.SelectedValue.ToString(), out int id_client);
            //SQLmanager.AddVehicle(textBox1.Text,textBox2.Text, comboBox1.SelectedValue.ToString(), id_client);
            Int32 id = Int32.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string reg = this.textBox1.Text;
            string model = this.textBox2.Text;
            string type = this.comboBox1.Text;

            SQLmanager.AddVehicle(reg, model, type, id);
            //MessageBox.Show("The vehicle has been added to database");
            this.Close();
            MessageBox.Show("The vehicle has been added to database");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sc = new SearchCustomer();
            sc.ShowDialog();
            dataGridView1.DataSource = sc.GetClient();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
