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
    public partial class ProductosVistas : Form
    {
        public ProductosVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();  
        private void ProductosVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorDatos;
        }
    }
}
