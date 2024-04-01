using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablasBss;

namespace TablasVistas
{
    public partial class ClienteMontoVista : Form
    {
        public ClienteMontoVista()
        {
            InitializeComponent();
        }
        ClienteMontBss bss = new ClienteMontBss();
        private void ClienteMontoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosMont;
        }
    }
}
