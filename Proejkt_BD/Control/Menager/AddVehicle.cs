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
            var types = SQLmanager.GetAllObjectTypes().ToList();
            comboBox1.DataSource = types;

            var clients = SQLmanager.GetAllClients().ToList();
            comboBox2.DataSource = clients;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(comboBox2.SelectedValue.ToString(), out int id_client);
            SQLmanager.AddVehicle(textBox1.Text,textBox2.Text, comboBox1.SelectedValue.ToString(), id_client);
        }
    }
}
