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

        private void frmAutores_Load(object sender, EventArgs e)
        {
            ActualizarListaAutorores();
            cboGenero.DataSource = Enum.GetValues(typeof(ClasesBiblioteca.GeneroLiterario));
            cboGenero.SelectedItem = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Autor a = ObtenerDatosFormulario();
            Autor.AgregarAutor(a);
            ActualizarDatosLista();
            LimpiarFormulario();
        }
        private Autor ObtenerDatosFormulario()
        {
            Autor Autor = new Autor();
            Autor.Documento = txtNroDocumento.Text;
            Autor.Genero = (GeneroLiterario)cboGenero.SelectedItem;
            Autor.NombreApellido = txtNombre.Text;
            Autor.Direccion = txtDireccion.Text;
            Autor.Telefono = txtTelefono.Text;

            return Autor;

        }
        private void ActualizarDatosLista()
        {
            lstAutor.DataSource = null;
            lstAutor.DataSource = Autor.listaAutor;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cboGenero.SelectedItem = null;
            txtNroDocumento.Text = "";
            txtTelefono.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Autor a = ObtenerDatosFormulario();
            if (this.lstAutor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }

            else
            {
                txtNombre.Focus();
                int indice = lstAutor.SelectedIndex;
                Autor.EditarAutor(a, indice);
                ActualizarListaAutorores();
            }
            LimpiarFormulario();
            ActualizarListaAutorores();
        }
        private void ActualizarListaAutorores()
        {
            lstAutor.DataSource = null;
            lstAutor.DataSource = Autor.ObtenerAutores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstAutor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila");
            }
            else
            {
                Autor a = (Autor)lstAutor.SelectedItem;
                Autor.EliminarAutor(a);
                ActualizarListaAutorores();
                LimpiarFormulario();
            }
        }

        private void lstAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autor a = (Autor)lstAutor.SelectedItem;

            if (a != null)
            {
                txtNombre.Text = a.NombreApellido;
                txtDireccion.Text = a.Direccion;
                txtTelefono.Text = a.Telefono;
                txtNroDocumento.Text = a.Documento;
                cboGenero.SelectedItem = a.Genero;
            }
        }
    }
}
