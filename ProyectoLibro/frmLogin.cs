using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBiblioteca;
using System.Data.SqlClient;

namespace ProyectoLibro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.isPassword = true;

            btnIngresar.Focus();

        }

        public void logins()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Funcionario WHERE usuario='" + txtUsuario.Text + "' AND contrasena='" + txtContraseña.Text + "'", con))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            string nombre= dr["nombre"].ToString();
                            MessageBox.Show("¡¡Bienvenido '" + nombre + "'!!.");
                            frmLogin form2 = new frmLogin();
                            form2.Close();
                            frmMenu form = new frmMenu();
                            form.Show();
                            
                           
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logins();
        }
    }
}
