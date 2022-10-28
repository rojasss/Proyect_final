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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class login : Form
    {
        bool sig;
        public login()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        //conexion 
        SqlConnection con = new SqlConnection(@"Data Source=GWTN156-5\SQLEXPRESS01;Initial Catalog=neptuno;Integrated Security=True");

        //metodo logear que va recibir dos string 
        public void logear(string IdCliente, string Pais)
        {
            //try para el manejo de errores 
            try
            {
                con.Open();//abrimos conexion
                //comando sql y pasamos los parametros
                SqlCommand cmd = new SqlCommand("SELECT idCliente,Pais FROM clientes WHERE idCliente = @idCliente AND Pais = @Pais",con);
                cmd.Parameters.AddWithValue("idCliente", IdCliente);//pasamos el primer parametro y que valor le damos 
                cmd.Parameters.AddWithValue("Pais", Pais);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);//creamos un objecto sda y le pasamos el comando cmd
                DataTable dt = new DataTable(); //creamos el dt para llenar los dtos de la tabla
                sda.Fill(dt); //llenar el datatable con los dt

                if(dt.Rows.Count==1){// si hay fila a sig le convierte a true
                    sig = true;
                }
                else
                {
                    MessageBox.Show(" ID O CONTRASEÑA INCORRECTA");
                }
                 
            }//en caso de una excepcion muestra un mensaje
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally// cerramos la conexion
            {
                con.Close();            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            logear(this.txtId.Text,this.txtPais.Text); //llamamos al metodo con los parametros
           // if(sig == true){
                menu men = new menu();
                men.Show();
                this.Hide();
          //  }
                
              
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
