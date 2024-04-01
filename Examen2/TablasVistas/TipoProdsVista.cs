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
    public partial class TipoProdsVista : Form
    {
        public TipoProdsVista()
        {
            InitializeComponent();
        }
        TipoProductBss bss = new TipoProductBss();
        private void TipoProdsVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductsTipo;
        }
    }
}
