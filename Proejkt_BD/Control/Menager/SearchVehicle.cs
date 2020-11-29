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
    public partial class SearchVehicle : Form
    {
        public IQueryable<Baza.OBJECT> _ob;
        public SearchVehicle(object id)
        {
            InitializeComponent();
            var result = Baza.SQLmanager.GetCustomerObject(id);
            dataGridView1.DataSource = result;
            this.dataGridView1.Columns["id_client"].Visible = false;
            //this.dataGridView1.Columns["obj_type"].Visible = false;
            this.dataGridView1.Columns["OBJ_TYPE1"].Visible = false;
            this.dataGridView1.Columns["CLIENT"].Visible = false;
        }

        public void SetVehicle(IQueryable<Baza.OBJECT> ob) => _ob = ob;

        public IQueryable<Baza.OBJECT> GetVehicle() => _ob;

        private void searchBox_Click(object sender, EventArgs e)
        {
            var result = Baza.SQLmanager.SearchObjects(textBox4.Text.ToString(), textBox3.Text.ToString(), textBox2.Text.ToString());
            dataGridView1.DataSource = result;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            AddVehicle av = new AddVehicle();
            av.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Baza.SQLmanager.ChooseObject(this.dataGridView1.CurrentRow.Cells[0].Value);
            SetVehicle(result);
            Close();
        }
    }
}
