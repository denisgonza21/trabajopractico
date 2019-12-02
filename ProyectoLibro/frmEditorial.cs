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
            txtNombre.Focus();
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

       
       

        private void lstEditorial_Click(object sender, EventArgs e)
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

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            Editorial edi = new Editorial();
            edi.nombre = txtNombre.Text;
            edi.direccion = txtDireccion.Text;
            edi.telefono = txtTelefono.Text;



            Editorial.AgregarEditorial(edi);
            LimpiarFormulario();
            ActualizarListaEditoriales();
        }

        private void btnModificar2_Click(object sender, EventArgs e)
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

        private void btnEliminar2_Click(object sender, EventArgs e)
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
