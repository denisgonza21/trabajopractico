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
using ClasesBiblioteca;

namespace ProyectoLibro
{
    public partial class frmDevolucion : Form
    {
        SqlConnection conexion = new SqlConnection("server = DENIS\\DENISSQLSERVER;Database = Biblioteca;User Id = sa;Password = 123");
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            cboNroCedula.Focus();
            txtNombre.Enabled = false;
            cboNroCedula.DataSource = Cliente.ObtenerCliente();
            cboNroCedula.SelectedItem = null;
            txtNombre.Text = "";
            txtId.Enabled = false;
            txtId.Text = "";
            cboNroCedula.Text = "";
            this.prestamoTableAdapter.Fill(this.bibliotecaDataSet1.Prestamo);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice;
            SqlCommand comando = new SqlCommand("SELECT * FROM Cliente where nroDocumento=@nroDocumento", conexion);
            comando.Parameters.AddWithValue("@nroDocumento", cboNroCedula.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombre.Text = registro["nombre"].ToString();
                indice = Convert.ToInt32(registro["id"]);
                txtId.Text = Convert.ToString(indice);
                String query = "select * from Prestamo WHERE cliente='" + txtId.Text + "'";
                updateGrid(query, "Prestamo");

            }
            conexion.Close();

            


        }
        public void updateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dtgDevolucion.DataSource = dad;
            dtgDevolucion.DataMember = tbl;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

