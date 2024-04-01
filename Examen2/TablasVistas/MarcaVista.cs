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
using TablasDAL;

namespace TablasVistas
{
    public partial class MarcaVista : Form
    {
        public MarcaVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaDatosBss;
        }
    }
}
