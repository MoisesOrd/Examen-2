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
    public partial class TablaProveedor : Form
    {
        public TablaProveedor()
        {
            InitializeComponent();
        }
        IngresoProveedorDal bss = new IngresoProveedorDal();
        private void TablaProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.IngresoProveedor();
        }
    }
}
