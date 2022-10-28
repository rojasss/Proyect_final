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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento f2 = new mantenimiento();
            f2.Show();
            this.Hide();
        }

        private void cONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {   consulta f2 = new consulta();
            f2.Show();
            this.Hide();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {   reporte f2 = new reporte();
            f2.Show();
            this.Hide();
        }
    }
}
