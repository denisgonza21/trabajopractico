using ClasesBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLibro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarListaCliente();
        }

        private void ActualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerCliente();
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)lstCliente.SelectedItem;
            if (cli != null)
            {
                txtDocumento.Text = cli.Documento;
                txtNombre.Text = cli.NombreApellido;
                txtDireccion.Text = cli.Direccion;
                txtTelefono.Text = Convert.ToString(cli.Telefono);
                dtpFechaIngreso.Value = cli.FechaInscripcion;
            }
        }




        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaIngreso.Value = System.DateTime.Now;

        }

        private Cliente ObtenerDatosFormulario()
        {
            Cliente cliente = new Cliente();
            cliente.NombreApellido = txtNombre.Text;
            cliente.Documento = txtDocumento.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text);
            cliente.FechaInscripcion = dtpFechaIngreso.Value.Date;

            return cliente;




        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //Cliente uwu = new Cliente();
            var uwu = ObtenerDatosFormulario();
            Cliente.AgregarCliente(uwu);
            LimpiarFormulario();
            ActualizarListaCliente();
            //lstCliente.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int index = lstCliente.SelectedIndex;

            Cliente.listaCliente[index] = ObtenerDatosFormulario();
            LimpiarFormulario();
            ActualizarListaCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Cliente  w = (Cliente)lstCliente.SelectedItem;
                Cliente.EliminarCliente(w);
                ActualizarListaCliente();
                LimpiarFormulario();
            }
        }
    }
}

