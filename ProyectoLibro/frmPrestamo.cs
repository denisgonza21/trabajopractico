﻿using ClasesBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoLibro
{
    public partial class frmPrestamo : Form
    {
        SqlConnection conexion = new SqlConnection("server = DENIS\\DENISSQLSERVER;Database = Biblioteca;User Id = sa;Password = 123");
      
        Prestamo prestamo;
        public frmPrestamo()
        {
            InitializeComponent();
        }


        private void ActualizarDataGrid()
        {
            dtgDetallePrestamo.DataSource= null;
            dtgDetallePrestamo.DataSource = prestamo.detalle_prestamo;
        }

        private void LimpiarFormulario(bool numero)
        {
            if (numero)
            {
                txtNombre.Text = "";
                cboNroDocumento.SelectedItem = null;
            }
            cboLibro.SelectedItem = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            dtpFechaVencimiento.Value = System.DateTime.Now;
            txtCantidad.Text = "1";
            txtEstado.Text = "";
            
            
         
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            cboNroDocumento.Focus();
            dtgDetallePrestamo.AutoGenerateColumns = true;
            cboNroDocumento.DataSource = Cliente.ObtenerCliente();
            cboLibro.DataSource = Libro.ObtenerLibros();
            cboNroDocumento.SelectedItem = null;
            cboLibro.SelectedItem = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            dtpFechaPrestamo.Enabled = false;
            txtCantidad.Text = "1";
            dtpFechaVencimiento.Value = System.DateTime.Now;
            prestamo = new Prestamo();
            txtEstado.Enabled = false;
            txtNombre.Enabled = false;
            txtNombre.Text = "";
           
        

        }

       

        private void dtgDetallePrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboNroDocumento_SelectedIndexChanged(object sender, EventArgs e)

        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Cliente where nroDocumento=@nroDocumento", conexion);
            comando.Parameters.AddWithValue("@nroDocumento", cboNroDocumento.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombre.Text = registro["nombre"].ToString();
                
            }
            conexion.Close();


        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            PrestamoDetalle pd = new PrestamoDetalle();
            pd.cantidad = Convert.ToDouble(txtCantidad.Text);
            pd.libro = (Libro)cboLibro.SelectedItem;
            pd.fecha_vencimiento = dtpFechaVencimiento.Value;
            pd.estado = Estado.No_Entregado;
            prestamo.detalle_prestamo.Add(pd);

            ActualizarDataGrid();


            LimpiarFormulario(false);
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            PrestamoDetalle pd = (PrestamoDetalle)dtgDetallePrestamo.CurrentRow.DataBoundItem;
            prestamo.detalle_prestamo.Remove(pd);
            ActualizarDataGrid();
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarFormulario(true);
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            prestamo.fecha_prestamo = dtpFechaPrestamo.Value.Date;
            prestamo.cliente = (Cliente)cboNroDocumento.SelectedItem;
            Prestamo.AgregarPrestamo(prestamo);
            MessageBox.Show("El prestamo ha sido guardado con éxito");
            LimpiarFormulario(true);
            dtgDetallePrestamo.DataSource = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            cboNroDocumento.SelectedItem = null;

            prestamo = new Prestamo();
        }
    }
}

