using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablasDAL;

namespace TablasVistas
{
    public partial class ClienteIngVista : Form
    {
        public ClienteIngVista()
        {
            InitializeComponent();
        }
        ClienteIngresoDal dal = new ClienteIngresoDal();

        private void ClienteIngVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dal.ClienteIng;
        }
    }
}
