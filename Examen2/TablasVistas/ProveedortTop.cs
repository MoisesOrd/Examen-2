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
    public partial class ProveedortTop : Form
    {
        public ProveedortTop()
        {
            InitializeComponent();
        }
        ProveedorSuminBss bss = new ProveedorSuminBss();
        private void ProveedortTop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorSuministrosTop;
        }
    }
}
