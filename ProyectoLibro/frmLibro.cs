﻿using System;
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

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            cmbAutor.SelectedItem = null;
            cmbEditorial.SelectedItem = null;
            txtcantEjemplares.Text = "";
            txtcantDisponible.Text = "";
            txtId.Text = "";

        }

        private void ActualizarListaLibros()
        {
            lstLibro.DataSource = null;
            lstLibro.DataSource = Libro.ObtenerLibros();
        }

       

        private Libro ObtenerLibroFormulario()
        {
            Libro libro = new Libro();
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                libro.id = Convert.ToInt32(txtId.Text);
            }
            
            libro.nombre = txtNombre.Text;
            libro.editorial = (Editorial)cmbEditorial.SelectedItem;
            libro.autor = (Autor)cmbAutor.SelectedItem;
            libro.cantidad_ejemplares = Convert.ToInt32(txtcantEjemplares.Text);
            libro.cantidad_disponible = Convert.ToInt32(txtcantDisponible.Text);
            return libro;
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            ActualizarListaLibros();
            cmbAutor.DataSource = Autor.ObtenerAutores();
            cmbEditorial.DataSource = Editorial.ObtenerEditoriales();
            cmbAutor.SelectedItem = null;
            cmbEditorial.SelectedItem = null;
            txtId.Enabled = false;
            ActualizarListaLibros();
            txtNombre.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        

        private void lstLibro_Click(object sender, EventArgs e)
        {
            Libro libro = (Libro)lstLibro.SelectedItem;

            if (libro != null)
            {
                txtId.Text = Convert.ToString(libro.id);
                txtNombre.Text = libro.nombre;
                cmbEditorial.SelectedItem = libro.editorial;
                cmbAutor.SelectedItem = libro.autor;
                int cant1 = libro.cantidad_ejemplares;
                txtcantEjemplares.Text = Convert.ToString(cant1);
                int cant2 = libro.cantidad_disponible;
                txtcantDisponible.Text = Convert.ToString(cant2);
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            try {
            Libro libro = new Libro();
            libro.nombre = txtNombre.Text;
            libro.editorial = (Editorial)cmbEditorial.SelectedItem;
            libro.autor = (Autor)cmbAutor.SelectedItem;
            libro.cantidad_ejemplares = Convert.ToInt32(txtcantEjemplares.Text);
            libro.cantidad_disponible = Convert.ToInt32(txtcantDisponible.Text);



            Libro.AgregarLibro(libro);
            LimpiarFormulario();
            ActualizarListaLibros();
        }
         catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            try {
            Libro libro = (Libro)lstLibro.SelectedItem;
            if (libro != null)
            {
                int index = lstLibro.SelectedIndex;
                Libro Lib = ObtenerLibroFormulario();
                Libro.EditarLibro(index, Lib);

                ActualizarListaLibros();
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

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            try {
            Libro libro = (Libro)lstLibro.SelectedItem;
            if (libro != null)
            {
                Libro p = (Libro)lstLibro.SelectedItem;
                Libro.EliminarLibro(p);
                ActualizarListaLibros();
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
    }
}
