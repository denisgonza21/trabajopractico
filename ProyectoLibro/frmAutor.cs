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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.nroDocumento = txtNroDocumento.Text;
            autor.nombre = txtNombre.Text;
            autor.direccion = txtDireccion.Text;
            autor.telefono = txtTelefono.Text;



            Autor.AgregarAutor(autor);
            LimpiarFormulario();
            ActualizarListaAutores();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";

        }

        private void ActualizarListaAutores()
        {
            lstAutor.DataSource = null;
            lstAutor.DataSource = Autor.ObtenerAutores();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            ActualizarListaAutores();
            txtId.Enabled = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Autor autor = (Autor)lstAutor.SelectedItem;
            if (autor != null)
            {
                int index = lstAutor.SelectedIndex;
                Autor a = ObtenerAutorFormulario();
                Autor.EditarAutor(index, a);


                LimpiarFormulario();
                ActualizarListaAutores();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
        }

        private Autor ObtenerAutorFormulario()
        {
            Autor autor = new Autor();
            autor.id = Convert.ToInt16(txtId.Text);
            autor.nroDocumento = txtNroDocumento.Text;
            autor.nombre = txtNombre.Text;
            autor.direccion = txtDireccion.Text;
            autor.telefono = txtTelefono.Text;
            return autor;



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Autor autor = (Autor)lstAutor.SelectedItem;
            if (autor != null)
            {
                Autor a = (Autor)lstAutor.SelectedItem;
                Autor.EliminarAutor(a);
                ActualizarListaAutores();
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

       

        private void lstAutor_Click(object sender, EventArgs e)
        {
            Autor autor = (Autor)lstAutor.SelectedItem;

            if (autor != null)
            {
                txtId.Text = Convert.ToString(autor.id);
                txtNroDocumento.Text = autor.nroDocumento;
                txtNombre.Text = autor.nombre;
                txtDireccion.Text = autor.direccion;
                txtTelefono.Text = autor.telefono;
            }
        }
    }
}
