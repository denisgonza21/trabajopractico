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

       

        private void LimpiarFormulario()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaIngreso.Value = System.DateTime.Now;
            txtId.Text = "";

        }


        private void ActualizarListaCliente()
        {
            lstCliente.DataSource = null;
            lstCliente.DataSource = Cliente.ObtenerCliente();
        }

        

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtId.Enabled=false;
            ActualizarListaCliente();
            txtDocumento.Focus();
            dtpFechaIngreso.Enabled = false;
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


    

       
       

        private void lstCliente_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)lstCliente.SelectedItem;

            if (c != null)
            {
                txtId.Text = Convert.ToString(c.id);
                txtDocumento.Text = Convert.ToString(c.nroDocumento);
                txtNombre.Text = c.nombre;
                txtDireccion.Text = c.direccion;
                txtTelefono.Text = c.telefono;
                dtpFechaIngreso.Value = c.fecha_inscripcion;
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
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

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            int index = lstCliente.SelectedIndex;
            Cliente c = ObtenerClienteFormulario();
            Cliente.EditarCliente(index, c);


            
            ActualizarListaCliente();
            LimpiarFormulario();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

