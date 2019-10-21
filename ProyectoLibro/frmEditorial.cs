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

namespace ProyectoLibro
{
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            ActualizarEditoriales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Editorial Edit = ObtenerDatosFormulario();
            Editorial.AgregarEditorial(Edit);
            ActualizarDatosLista();
            LimpiarFormulario();
        }
        private Editorial ObtenerDatosFormulario()
        {
            Editorial Editorial = new Editorial();
            Editorial.Nombre = txtNombre.Text;
            Editorial.Direccion = txtDireccion.Text;
            Editorial.Telefono = txtTelefono.Text;

            return Editorial;

        }
        private void ActualizarDatosLista()
        {
            lstEditorial.DataSource = null;
            lstEditorial.DataSource = Editorial.listaEditoriales;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Editorial Edit = ObtenerDatosFormulario();
            if (this.lstEditorial.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }

            else
            {
                txtNombre.Focus();
                int indice = lstEditorial.SelectedIndex;
                Editorial.EditarEditorial(Edit, indice);
                ActualizarEditoriales();
            }
            LimpiarFormulario();
            ActualizarEditoriales();
        }
        private void ActualizarEditoriales()
        {
            lstEditorial.DataSource = null;
            lstEditorial.DataSource = Editorial.ObtenerEditoriales();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEditorial.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Editorial Edit = (Editorial)lstEditorial.SelectedItem;
                Editorial.EliminarEditorial(Edit);
                ActualizarEditoriales();
                LimpiarFormulario();
            }
        }

        private void lstEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editorial Edit = (Editorial)lstEditorial.SelectedItem;

            if (Edit != null)
            {
                txtNombre.Text = Edit.Nombre;
                txtDireccion.Text = Edit.Direccion;
                txtTelefono.Text = Edit.Telefono;
            }
        }
    }
}
