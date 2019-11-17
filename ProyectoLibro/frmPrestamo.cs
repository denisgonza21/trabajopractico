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
            cboCliente.SelectedItem = null;
            cboLibro.SelectedItem = null;
            dtpFechaPrestamo.Value = System.DateTime.Now;
            dtpFechaVencimiento.Value = System.DateTime.Now;
         
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PrestamoDetalle pd = (PrestamoDetalle)dtgDetallePrestamo.CurrentRow.DataBoundItem;
            prestamo.detalle_prestamo.Remove(pd);
            ActualizarDataGrid();
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            dtgDetallePrestamo.AutoGenerateColumns = true;
            cboCliente.DataSource = Cliente.ObtenerClientes();
            cboLibro.DataSource = Libro.ObtenerLibros();
            cboCliente.SelectedItem = null;
            cboLibro.SelectedItem = null;
            prestamo = new Prestamo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            prestamo.FechaPrestamo = dtpFechaPrestamo.Value.Date;
            prestamo.Cliente = (Cliente)cboCliente.SelectedItem;

            PrestamoDetalle pd = new PrestamoDetalle();
            pd.libro = (Libro)cboLibro.SelectedItem;

            prestamo.detalle_prestamo.Add(pd);
            ActualizarDataGrid();

            Limpiar();
        }


        private void Limpiar()
        {
            cboCliente.SelectedItem = null;
            cboLibro.SelectedItem = null;

           
        }

        /*private void btnModificar_Click(object sender, EventArgs e)
        {
            Prestamo prest = (Editorial)dtgDetallePrestamo;
            if (edito != null)
            {
                int index = dtgDetallePrestamo.SelectedIndex;
                Editorial ed = ObtenerEditorialFormulario();
                Editorial.EditarEditorial(index, ed);


                LimpiarFormulario();
                ActualizarListaEditoriales();
            }
            else
            {
                MessageBox.Show("Ojo, Selecciona un Item");
            }
        }*/
    }
}

