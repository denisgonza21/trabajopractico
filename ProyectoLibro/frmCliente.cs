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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nroDocumento = txtDocumento.Text;
            cliente.nombre = txtNombre.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.fecha_inscripcion = dtpFechaIngreso.Value.Date;


            Cliente.AgregarCliente(cliente);
            LimpiarFormulario();
            ActualizarListaCliente();
        }

        private void LimpiarFormulario()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaIngreso.Value = System.DateTime.Now;

        }


        private void ActualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int index = lstCliente.SelectedIndex;
            Cliente c = ObtenerClienteFormulario();
            Cliente.EditarCliente(index, c);


            LimpiarFormulario();
            ActualizarListaCliente();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Cliente c = (Cliente)lstCliente.SelectedItem;
                Cliente.EliminarCliente(c);
                ActualizarListaCliente();
                LimpiarFormulario();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ActualizarListaCliente();
        }


        private Cliente ObtenerClienteFormulario()
        {
            Cliente cliente = new Cliente();
            cliente.nroDocumento = txtDocumento.Text;
            cliente.nombre = txtNombre.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.fecha_inscripcion = dtpFechaIngreso.Value.Date;
            return cliente;
        }


        private void lstCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)lstCliente.SelectedItem;

            if (c != null)
            {
                txtDocumento.Text = Convert.ToString(c.nroDocumento);
                txtNombre.Text = c.nombre;
                txtDireccion.Text = c.direccion;
                txtTelefono.Text = c.telefono;
                dtpFechaIngreso.Value = c.fecha_inscripcion;
            }



        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}

