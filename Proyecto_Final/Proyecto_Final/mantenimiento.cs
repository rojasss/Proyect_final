using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class mantenimiento : Form
    {

        public mantenimiento()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtCampaña.Text = "";
            txtCargoContac.Text = "";
            txtCiudad.Text = "";
            txtDirrecion.Text = "";
            txtNomContac.Text = "";
            txtPais.Text = "";
            txtTelef.Text = "";

        }
        Clase_Matenimiento datosMantenimiento = new Clase_Matenimiento();

        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta f2 = new consulta();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into clientes (idCliente,NombreCompañia,NombreContacto,CargoContacto,Direccion,Ciudad,Pais,Telefono) values('" + this.txtId.Text + "','" + this.txtCampaña.Text + "','" + this.txtCargoContac.Text + "','" + this.txtCargoContac.Text + "','" + this.txtDirrecion.Text + "','" + this.txtCiudad.Text + "','" + this.txtPais.Text + "','" + this.txtTelef.Text + "')";

            if (datosMantenimiento.registrar(sql))
            {
                MessageBox.Show("registro listo");
                
                this.dgvMantenimiento.Refresh();
                limpiar();
            }
            else
            {
                MessageBox.Show("error");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {
            datosMantenimiento.consultar("select * from clientes", "clientes");
            this.dgvMantenimiento.DataSource = datosMantenimiento.ds.Tables["clientes"];
            this.dgvMantenimiento.Refresh();
        }
    }
}
