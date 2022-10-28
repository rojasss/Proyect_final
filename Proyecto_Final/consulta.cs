using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void consulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento f2 = new mantenimiento();
            f2.Show();
            this.Hide();
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte f2 = new reporte();
            f2.Show();
            this.Hide();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu f2 = new menu();
            f2.Show();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
