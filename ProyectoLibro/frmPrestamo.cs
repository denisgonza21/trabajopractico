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
    public partial class frmPrestamo : Form
    {
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

        private void LimpiarFormulario()
        {
            
            cboLibro.SelectedItem = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            dtpFechaVencimiento.Value = System.DateTime.Now;
            txtCantidad.Text = "1";
         
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            dtgDetallePrestamo.AutoGenerateColumns = true;
            cboCliente.DataSource = Cliente.ObtenerClientes();
            cboLibro.DataSource = Libro.ObtenerLibros();
            cboCliente.SelectedItem = null;
            cboLibro.SelectedItem = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            dtpFechaPrestamo.Enabled = false;
            txtCantidad.Text = "1";
            dtpFechaVencimiento.Value = System.DateTime.Now;
            prestamo = new Prestamo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrestamoDetalle pd = new PrestamoDetalle();
            pd.cantidad = Convert.ToDouble(txtCantidad.Text);
            pd.libro = (Libro)cboLibro.SelectedItem;
            prestamo.detalle_prestamo.Add(pd);
            ActualizarDataGrid();

            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PrestamoDetalle pd = (PrestamoDetalle)dtgDetallePrestamo.CurrentRow.DataBoundItem;
            prestamo.detalle_prestamo.Remove(pd);
            ActualizarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prestamo.fecha_prestamo = dtpFechaPrestamo.Value.Date;
            prestamo.cliente = (Cliente)cboCliente.SelectedItem;

            Prestamo.AgregarPrestamo(prestamo);
            MessageBox.Show("El prestamo ha sido guardado con éxito");
            LimpiarFormulario();
            dtgDetallePrestamo.DataSource = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            cboCliente.SelectedItem = null;
            prestamo = new Prestamo();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}

