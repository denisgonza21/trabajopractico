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
            txtNroDocumento.Focus();
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

        private void btnAgregar2_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarCampos())
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
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
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private bool ValidarCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNroDocumento.Text))
            {
                MessageBox.Show("El campo de Nro Documento no puede estar vacío", "Error");
                txtNroDocumento.Focus();
                return false;
            }
            return true;
        }
    }
}
