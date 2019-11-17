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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Editorial edi = new Editorial();
            edi.nombre = txtNombre.Text;
            edi.direccion = txtDireccion.Text;
            edi.telefono = txtTelefono.Text;



            Editorial.AgregarEditorial(edi);
            LimpiarFormulario();
            ActualizarListaEditoriales();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

        }

        private void ActualizarListaEditoriales()
        {
            lstEditorial.DataSource = null;
            lstEditorial.DataSource = Editorial.ObtenerEditoriales();
        }

        private void frmEditorial_Load(object sender, EventArgs e)
        {
            ActualizarListaEditoriales();
            txtId.Enabled = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            Editorial edito = (Editorial)lstEditorial.SelectedItem;
            if (edito != null)
            {
                int index = lstEditorial.SelectedIndex;
                Editorial ed = ObtenerEditorialFormulario();
                Editorial.EditarEditorial(index, ed);


                LimpiarFormulario();
                ActualizarListaEditoriales();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
        }

        private Editorial ObtenerEditorialFormulario()
        {
            Editorial editorial = new Editorial();
            editorial.id = Convert.ToInt16(txtId.Text);
            editorial.nombre = txtNombre.Text;
            editorial.direccion = txtDireccion.Text;
            editorial.telefono = txtTelefono.Text;
            return editorial;



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Editorial edito = (Editorial)lstEditorial.SelectedItem;
            if (edito != null)
            {
                Editorial p = (Editorial)lstEditorial.SelectedItem;
                Editorial.EliminarEditorial(p);
                ActualizarListaEditoriales();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lstEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Editorial edi = (Editorial)lstEditorial.SelectedItem;

            if (edi != null)
            {
                txtId.Text = Convert.ToString(edi.id);
                txtNombre.Text = edi.nombre;
                txtDireccion.Text = edi.direccion;
                txtTelefono.Text = edi.telefono;
            }
        }
    }
}
