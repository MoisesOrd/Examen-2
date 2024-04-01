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
    public partial class VendedorVista : Form
    {
        public VendedorVista()
        {
            InitializeComponent();
        }
        VendedorBss bss = new VendedorBss();
        private void VendedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DatosVendedor;
        }
    }
}
