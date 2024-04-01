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
    public partial class TablaCliente : Form
    {
        public TablaCliente()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss(); 
        private void TablaCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosBss;
        }
    }
}
