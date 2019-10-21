using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesBiblioteca;
using System.Windows.Forms;

namespace ProyectoLibro
{
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        
        

        

        private void frmLibro_Load(object sender, EventArgs e)
        {
            ActualizarListaLibros();
           // cmbAutor.DataSource = Autor.;
           // cmbEditorial.DataSource = Editorial.;
            cmbAutor.SelectedItem = null;
            cmbEditorial.SelectedItem = null;
           
        }

        private void ActualizarListaLibros()
        {
            lstlibros.DataSource = null;
            lstlibros.DataSource = Libro.ObtenerLibros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            var p = ObtenerDatosFormulario();
            Libro.AgregarLibro(p);
            ActualizarListaLibros();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtcantDisponible.Text = "";
            txtcantEjemplares.Text = "";
            cmbAutor.SelectedItem = null;
            cmbEditorial.SelectedItem = null;
        }

        private Libro ObtenerDatosFormulario()
        {
            Libro libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.cantidad_ejemplares = Convert.ToInt32(txtcantEjemplares.Text);
            libro.cantidad_disponible = Convert.ToInt32(txtcantDisponible.Text);
            libro.autor = (Autor)cmbAutor.SelectedItem;
            libro.editorial = (Editorial)cmbEditorial.SelectedItem;
            return libro;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var p = ObtenerDatosFormulario();
            if (this.lstlibros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }

            else
            {
                int indice = lstlibros.SelectedIndex;
                Libro.EditarLibro(p, indice);
                ActualizarListaLibros();
                LimpiarFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstlibros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Libro p = (Libro)lstlibros.SelectedItem;
                Libro.EliminarLibro(p);
                ActualizarListaLibros();
                LimpiarFormulario();
            }
        }

        private void txtcantEjemplares_Leave(object sender, EventArgs e)
        {
            int cantEjemplares = Convert.ToInt32(txtcantEjemplares.Text);
            txtcantEjemplares.Text = Convert.ToString(cantEjemplares);
            txtcantDisponible.Text = Convert.ToString(cantEjemplares);
        }

        private void lstlibros_Click(object sender, EventArgs e)
        {
            Libro p = (Libro)lstlibros.SelectedItem;

            if (p != null)
            {
                txtNombre.Text = p.Nombre;
                txtcantEjemplares.Text = Convert.ToString(p.cantidad_ejemplares);
                txtcantDisponible.Text = Convert.ToString(p.cantidad_disponible);
                cmbEditorial.SelectedItem = p.editorial;
                cmbAutor.SelectedItem = p.autor;
                

            }
        }
    }
}
